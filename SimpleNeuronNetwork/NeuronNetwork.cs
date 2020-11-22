using System;
using System.Collections.Generic;
using System.Linq;
using SimpleNeuronNetwork.Neurons;

namespace SimpleNeuronNetwork
{
    public class NeuronNetwork
    {
        private List<InputNeuron> _inputNeurons = new List<InputNeuron>();
        private Neuron _outputNeuron = new Neuron();
        private double _learnigRate;

        public NeuronNetwork(int countInputNeurons, double learningRate)
        {
            _learnigRate = learningRate;

            var rand = new Random();
            for (var i = 0; i < countInputNeurons; i++)
            {
                _inputNeurons.Add(new InputNeuron());

                _outputNeuron.Weights.Add(new PairWeightOutput()
                {
                    Weight = rand.NextDouble()
                });
            }
        }

        public double Execute(params double[] inputs)
        {
            if (inputs.Length == _inputNeurons.Count)
            {
                var i = 0;
                return _outputNeuron.ActivationFunc(_inputNeurons
                                                    .Select(neuron => neuron.ActivationFunc(inputs[i++]))
                                                    .ToArray()
                                                   );
            }
            else
            {
                throw new ArgumentException("Invalid input data length", nameof(inputs));
            }
        }

        public void Train(double expected, params double[] inputs)
        {
            var actual = Execute(inputs);
            _outputNeuron.LastError = actual - expected;
            var weightsDelta = _outputNeuron.LastError * (1 - Math.Pow(_outputNeuron.Output, 2));

            for (int i = 0; i < 4; i++)
            {
                _outputNeuron.Weights[i].Weight = _outputNeuron.Weights[i].Weight - _inputNeurons[i].Output * weightsDelta * _learnigRate;
            }
        }
    }
}
