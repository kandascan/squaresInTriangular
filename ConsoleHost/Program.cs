using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculation;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var input = GetInputValueFromUser();
                if (input.Length != 2)
                    throw new Exception("Forgot added or too more parameters");
                var n = Convert.ToInt16(input[0]);
                var m = Convert.ToInt16(input[1]);

                var result = Calculation.Calculation.Process(n, m);

                Console.WriteLine("Triangular contais {0} squares", result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        static string[] GetInputValueFromUser()
        {
            Console.Write("Give N i M value for calculation (only integer value): ");
            var input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
                throw new Exception("Input value cannot be null or empty string");

            return input.Split(' ');
        }
    }
}
