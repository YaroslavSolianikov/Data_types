using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_types_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Angle: ");
            double a = double.Parse(Console.ReadLine());
            double b = (a * Math.PI) / 180;
            double res = Math.Sin(b);
            Console.WriteLine("Sinus: " + res);
            Console.ReadKey();
        }
    }
}
