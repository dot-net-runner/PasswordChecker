using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPassword.SimpleNeuronNetwork
{
    public static class BoolExtensions
    {
        public static int ToInt(this bool value)
        {
            return value ? 1 : 0;
        }
    }
}
