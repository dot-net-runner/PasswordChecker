using SimpleNeuronNetwork;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CheckPassword.PasswordChecker
{
    public class PasswordChecker
    {
        private const int COUNT_IPNUT_NEURONS = 5;
        private const double LEARNING_RATE = 0.005;

        private NeuronNetwork _nn;


        public PasswordChecker(string datasetFile)
        {
            _nn = new NeuronNetwork(COUNT_IPNUT_NEURONS, LEARNING_RATE);

            foreach (var line in File.ReadLines(datasetFile))
            {
                var data = line.Split(" ");
                try
                {
                    var result = int.Parse(data[1]);
                    switch (result)
                    {
                        case 0:
                            result = -1;
                            break;

                        case 1:
                            result = 0;
                            break;

                        case 2:
                            result = 1;
                            break;

                        default:
                            continue;
                    }

                    _nn.Train(result, ParsePassword(data[0]));
                }
                catch { }
            }
        }

        public double Check(string password)
        {
            return _nn.Execute(ParsePassword(password));
        }

        public double[] ParsePassword(string password)
        {
            return new double[]
            {
                password.Length,
                password.Count(char.IsUpper),
                password.Count(char.IsLower),
                password.Count(char.IsDigit),
                password.Count(c => new Regex("[^a-z0-9]")
                                        .IsMatch(c.ToString())
                                        )
            };
        }
    }
}
