using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_types_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 sides: A and B");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Hypotenuse: " + c);
            Console.ReadKey();

        }
    }
}
