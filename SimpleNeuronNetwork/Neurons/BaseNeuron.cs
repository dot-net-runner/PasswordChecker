namespace SimpleNeuronNetwork.Neurons
{
    internal abstract class BaseNeuron
    {
        public double Output { get; protected set; }

        public abstract double ActivationFunc(params double[] x);
    }
}
