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
            Console.WriteLine("Enter 2 for GetFibonacciSeries");
            Console.WriteLine("Enter 3 for Currency Converter");
            Console.WriteLine("Enter 4 for The Chase Assessment Solution Problem");

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

            if (action == "2")
            {
                Console.WriteLine("Please enter the number of elements in the sequence");
                string numberOfItems = Console.ReadLine();
                int.TryParse(numberOfItems, out int numItems);
                if (numItems <= 0)
                {
                    Console.WriteLine("Please enter a number greater than 0");
                }

                if (numItems > 0)
                {
                    List<int> series = Numbers.GetFibonacciSeries(numItems);
                    string seriesString = "";

                    //Build String from List
                    for (int i = 0; i < series.Count; i++)
                    {
                        seriesString += series[i];

                        if (i <= (series.Count - 2))
                        {
                            seriesString += ", ";
                        }

                        if (i == (series.Count - 1))
                        {
                            seriesString += ".";
                        }
                    }

                    Console.WriteLine("================== RESULT =======================");
                    Console.WriteLine();
                    Console.WriteLine(seriesString);
                    Console.WriteLine();
                    Console.WriteLine("==================== END ========================");
                }
            }

            if (action == "3")
            {
                Console.WriteLine("Press 1 to enter Dollar amount");
                Console.WriteLine("Press 2 to enter Naira amount");
                string currencyOption = Console.ReadLine();
                string currency = "Naira";
                string nairaSign = "N";
                string dollarSign = "$";

                if (currencyOption == "1")
                {
                    currency = "Dollar";
                }

                Console.WriteLine("Enter " + currency + " amount");
                string amountSupplied = Console.ReadLine();
                float.TryParse(amountSupplied, out float amount);
                float result = Numbers.CurrencyConverter(currency, amount);

                Console.WriteLine();
                Console.WriteLine("================== RESULT =======================");
                Console.WriteLine();
                Console.WriteLine("Rate used N460 to $1");
                if (currencyOption == "1")
                {
                    Console.WriteLine(dollarSign + amount.ToString("#,##0") + " is " + nairaSign + result.ToString("#,##0.00") + " in Naira");
                }
                else
                {
                    Console.WriteLine(nairaSign + amount.ToString("#,##0") + " is " + dollarSign + result.ToString("#,##0.00") + " in Dollars");
                }
                Console.WriteLine();
                Console.WriteLine("==================== END ========================");
            }

            if (action == "4")
            {
                //Assessment Problem
                Console.WriteLine("Welcome To The AlgoSection.");
                Console.WriteLine("I Accept a list of numbers in this format { 2,3,4,5,6 ; 7,8,9,3,2 }");
                Console.WriteLine("Returns a sorted array with odd numbers first");
                Console.WriteLine("Please enter the numbers");
                string inputString = Console.ReadLine();
                string[] inputStringArray = inputString.Split(";");

                List<int> outputArrayEven = new List<int>();
                List<int> outputArrayOdd = new List<int>();
                string[] oneArray = inputStringArray[0].Split(",");
                string[] twoArray = inputStringArray[1].Split(",");

                foreach (var item in oneArray)
                {
                    int.TryParse(item.ToString(), out int itemInt);
                    if (itemInt % 2 == 0)
                    {
                        outputArrayEven.Add(itemInt);
                    }
                    else
                    {
                        outputArrayOdd.Add(itemInt);
                    }
                }

                foreach (var item in twoArray)
                {
                    int.TryParse(item.ToString(), out int itemInt);
                    if (itemInt % 2 == 0)
                    {
                        outputArrayEven.Add(itemInt);
                    }
                    else
                    {
                        outputArrayOdd.Add(itemInt);
                    }
                }
                outputArrayEven.Sort();
                outputArrayOdd.Sort();

                outputArrayOdd.AddRange(outputArrayEven);
                Console.WriteLine(string.Join(",", outputArrayOdd));
            }
        }
    }
}
