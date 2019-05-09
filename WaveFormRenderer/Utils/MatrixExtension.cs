using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaveFormRendererApp.Utils
{
    public static class MatrixExtension
    {
        public static IEnumerable<double> Mult(this IEnumerable<IEnumerable<int>> a, IEnumerable<double> b)
        {
            List<double> c = new List<double>();
            if (a.Count() == b.Count()) {
                for (int i = 0; i < a.Count(); i++)
                {
                    double sum = 0;
                    for (int j = 0; j < a.ElementAt(0).Count(); j++)
                    {
                        sum += a.ElementAt(i).ElementAt(j) * b.ElementAt(j);
                    }
                    c.Add(sum);
                }
            }
            return c;
        }

        public static IEnumerable<float> Mult(this IEnumerable<IEnumerable<int>> a, IEnumerable<float> b)
        {
            List<float> c = new List<float>();
            if (a.Count() == b.Count())
            {
                for (int i = 0; i < a.Count(); i++)
                {
                    float sum = 0;
                    for (int j = 0; j < a.ElementAt(0).Count(); j++)
                    {
                        sum += a.ElementAt(i).ElementAt(j) * b.ElementAt(j);
                    }
                    c.Add(sum);
                }
            }
            return c;
        }

        public static IEnumerable<float> MultWithDiv(this IEnumerable<IEnumerable<int>> a, IEnumerable<float> b)
        {
            List<float> c = new List<float>();
            if (a.Count() == b.Count())
            {
                for (int i = 0; i < a.Count(); i++)
                {
                    float sum = 0;
                    for (int j = 0; j < a.ElementAt(0).Count(); j++)
                    {
                        sum += a.ElementAt(i).ElementAt(j) * b.ElementAt(j);
                        sum /= 256;
                    }
                    c.Add(sum);
                }
            }
            return c;
        }

        public static IEnumerable<double> Mult(this IEnumerable<IEnumerable<double>> a, IEnumerable<IEnumerable<double>> b)
        {
            List<double> c = new List<double>();
            if (a.Count() == b.Count())
            {
                for (int i = 0; i < a.Count(); i++)
                {
                    double sum = 0;
                    for (int j = 0; j < a.ElementAt(0).Count(); j++)
                    {
                        sum += a.ElementAt(i).ElementAt(j) * b.ElementAt(j).ElementAt(i);
                    }
                    c.Add(sum);
                }
            }
            return c;
        }
    }
}
