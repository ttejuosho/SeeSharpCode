using System;
using System.Collections.Generic;
using System.Linq;

namespace SeeSharpBoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Console");
            Console.WriteLine("Please use the options below");

            Console.WriteLine("Enter 1 for GetAverage");

            string action = Console.ReadLine();

            if (action == "1")
            {
                Console.WriteLine("How many numbers will you be providing ?");
                string numberOfItems = Console.ReadLine();
                int.TryParse(numberOfItems, out int numItems);
                List<float> averageList = new List<float>();

                for (int i = 1; i <= numItems; i++)
                {
                    Console.WriteLine("Please enter number " + i);
                    string currentNumber = Console.ReadLine();
                    float.TryParse(currentNumber, out float currentNum);
                    averageList.Add(currentNum);
                }

                try
                {
                    string average = Numbers.GetAverage(averageList);
                    Console.WriteLine("Calculated Average is " + average);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    //Console.WriteLine("Enter 3 Numbers");
                }
            }
        }
    }
}
