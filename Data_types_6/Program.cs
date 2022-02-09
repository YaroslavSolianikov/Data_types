using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_types_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter price: ");
            double pr = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter discount in %: ");
            double dis = double.Parse(Console.ReadLine());
            double res = (pr / 100 * dis);
            Console.WriteLine("discount = " + res);
            Console.ReadKey();
        }
    }
}
