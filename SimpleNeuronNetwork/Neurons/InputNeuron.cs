using System;
using System.Linq;

namespace SimpleNeuronNetwork.Neurons
{
    internal class InputNeuron : BaseNeuron
    {
        public override double ActivationFunc(params double[] x)
        {
            Output = Math.Tanh(x.Sum());

            return Output;
        }
    }
}
