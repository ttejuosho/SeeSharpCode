using System;
using System.Collections.Generic;

namespace SeeSharpBoi
{
    class Numbers
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
    }
}