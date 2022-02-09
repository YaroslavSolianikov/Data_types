using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_types_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter meters: ");
            double m = double.Parse(Console.ReadLine());
            double sm = 100 * m;
            Console.WriteLine($"Meters: {m}, Centimeters: {sm}");
            Console.ReadKey();
        }
    }
}
