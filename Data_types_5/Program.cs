using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_types_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Sum = " + (a + b ));
            Console.WriteLine("Sub = " + (a - b));
            Console.WriteLine("Mult = " + (a * b));
            Console.WriteLine("Div = " + (a / b));
            Console.ReadKey();
        }
    }
}
