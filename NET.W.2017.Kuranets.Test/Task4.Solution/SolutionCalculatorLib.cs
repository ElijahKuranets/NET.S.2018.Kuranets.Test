using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Solution
{
    static class SolutionCalculatorLib
    {
        public static double CalculateAverage(this AveragingMethod averagingMethod, List<double> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            switch (averagingMethod)
            {
                case AveragingMethod.Mean:
                    return values.Sum() / values.Count;

                case AveragingMethod.Median:
                    var sortedValues = values.OrderBy(x => x).ToList();
                   
                    int n = sortedValues.Count();

                    if (n % 2 == 1)
                    {
                        return sortedValues[(n - 1) / 2];
                    }

                    return (sortedValues[sortedValues.Count / 2 - 1] + sortedValues[n / 2]) / 2;
                case AveragingMethod.Fibonacci:
                    int a = 0;
                    int b = 1;
                   
                    for (int i = 0; i < 15; i++)
                    {
                        int temp = a;
                        a = b;
                        b = temp + b;
                    }
                    return a;
            
            default:
                    throw new ArgumentException("Invalid averagingMethod value");
            }
        }
    }
}

