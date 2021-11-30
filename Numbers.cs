using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SeeSharpBoi
{
    public class Numbers
    {
        public static string GetAverage(List<float> numbers)
        {
            float total = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                total += numbers[i];
            }
            float average = total / numbers.Count;
            return average.ToString("0.00");
        }

        public static List<int> GetFibonacciSeries(int count)
        {
            List<int> series = new List<int>
            {
                0, 1, 1
            };

            if (count == 2)
            {
                series.RemoveAt(2);
            }

            if (count == 1)
            {
                series.RemoveAt(2);
                series.RemoveAt(1);
            }

            if (count > 3)
            {
                int counter = count - 3;
                while (counter > 0)
                {
                    int nextTerm = series.ElementAt(series.Count() - 1) + series.ElementAt(series.Count() - 2);
                    series.Add(nextTerm);
                    counter--;
                }
            }
            return series;
        }

        public static float CurrencyConverter(string currency, float amount)
        {
            if (currency == "Dollar")
            {
                return amount * 460;
            }

            return amount / 460;
        }
    }
}