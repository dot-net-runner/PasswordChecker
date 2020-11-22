using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleNeuronNetwork.Neurons
{
    internal class Neuron : BaseNeuron
    {
        public List<PairWeightOutput> Weights { get; private set; } = new List<PairWeightOutput>();

        public double LastError { get; set; }


        public override double ActivationFunc(params double[] outputs)
        {
            if (outputs.Length == outputs.Length)
            {
                var i = 0;
                Output = Math.Tanh(outputs.Sum(
                         output =>
                         {
                             Weights[i].Output = output;

                             return output * Weights[i++].Weight;
                         }));

                return Output;
            }
            else
            {
                throw new ArgumentException("Invalid input data length", nameof(outputs));
            }
        }
    }
}
