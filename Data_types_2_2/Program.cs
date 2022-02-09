using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_types_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = 3.141;

            Console.WriteLine("Enter radius:");
            double r = double.Parse(Console.ReadLine());

            double s = (Pi * Math.Pow(r, 2));
            Console.WriteLine("Square: " +s);
            Console.ReadKey();
        }
    }
}
