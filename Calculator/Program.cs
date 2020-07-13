using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,sum,substract,multiply,divide;
            Console.WriteLine("Enter first and second number");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("Sum of two nos. is");
            Console.WriteLine(sum);
            substract = a - b;
            Console.WriteLine("Substarction of two nos. is");
            Console.WriteLine(substract);
            multiply = a*b;
            Console.WriteLine("Multiplication of two nos. is");
            Console.WriteLine(multiply);
            divide = a / b;
            Console.WriteLine("Division of two nos. is");
            Console.WriteLine(divide);
        }
    }
}
