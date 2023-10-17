using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Class_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first numerical value: ");
            double value1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second numerical value: ");
            double value2 = Convert.ToDouble(Console.ReadLine());

            double result = CalculateSumOrTriple(value1, value2);

            Console.WriteLine("The result is: " + result);
        }

        static double CalculateSumOrTriple(double value1, double value2)
        {
            if (value1 == value2)
            {
                return 3 * (value1 + value2);
            }
            else
            {
                return value1 + value2;
            }
        }
    }
}
