using System;

namespace SeeSharpBoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Console");
            // Console.WriteLine("Username:");
            // var username = Console.ReadLine();
            // Console.WriteLine("Password:");
            // var password = Console.ReadLine();
            // if (username.ToLower() == "taiwo tejuosho" && password == "Aliyah422" ){
            //     Console.WriteLine("Welcome Taiwo");
            // } else {
            //     Console.WriteLine("Welcome " + username);
            // }
            Console.WriteLine("Enter 3 Numbers");
            string num1 = Console.ReadLine();
            int num11;
            int.TryParse(num1, out num11);
            string num2 = Console.ReadLine();
            int num21;
            int.TryParse(num2, out num21);
            string num3 = Console.ReadLine();
            int num31;
            int.TryParse(num3, out num31);
            try
            {
            if (num11 == 0 || num21 == 0 || num31 == 0){
                throw new Exception("Please Enter 3 Numbers");
            } else {
            int average = Numbers.GetAverage(num11, num21, num31);
            Console.WriteLine("The Average of " + num1 + " " + num2 + " " + num3 + " is " + average);
            }
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            Console.WriteLine("Enter 3 Numbers");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
            }
        }
    }
}
