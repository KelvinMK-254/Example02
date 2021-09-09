using System;
using System.Text.RegularExpressions;
using Exercise01;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPress 'Q' to quit.");
            Console.WriteLine("\nEnter a Number to convert to words");
            string numberInput = Console.ReadLine();
            //Exit if input is 'Q'
            if(numberInput == "Q")
            {
                Environment.Exit(0);
            }
            //Check if input is numeric
            bool isNumber = Regex.IsMatch(numberInput, @"-?\d+(\.\d+)?");
            if (!isNumber)
            {
                Console.WriteLine("\nInvalid input");
                Environment.Exit(0);
            }
            var myNumberType = (ulong)UInt64.Parse(numberInput);
            var result = Exercise1.Towards(myNumberType);
            Console.WriteLine("The number in words is \n{0}", result);

            while (numberInput != "Q")
            {
                Console.WriteLine("\nEnter a new number to convert to words");
                string numberInput_Loop = Console.ReadLine();
                //Exit if input is 'Q'
                if (numberInput_Loop == "Q")
                {
                    Environment.Exit(0);
                }
                //Check if input is numeric
                bool isNumber_Loop = Regex.IsMatch(numberInput, @"-?\d+(\.\d+)?");
                if (!isNumber_Loop)
                {
                    Console.WriteLine("\nInvalid input");
                    Environment.Exit(0);
                }
                var myNumberType_Loop = (ulong)UInt64.Parse(numberInput_Loop);
                var result_Loop = Exercise1.Towards(myNumberType_Loop);
                Console.WriteLine("The number in words is \n{0}", result_Loop);

            }
        }
    }
}
