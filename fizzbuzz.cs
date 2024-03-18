using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        static void Main(string[] args)
        {
            bool isNumber = false;
            int userInput = -1;
            string result;
            while (userInput != 0)
            {
                result = "";
                Console.Clear();
                Console.Write("Enter a number or '0' to stop:");
                isNumber = int.TryParse(Console.ReadLine(),out userInput);
                if (isNumber && userInput != 0)
                {
                    if (userInput % 3 == 0)
                    {
                        result += "fizz";
                    };
                    if (userInput % 5 == 0)
                    {
                        result += "buzz";
                    };
                };
                Console.WriteLine(result);
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();
            };
        }
    }
}