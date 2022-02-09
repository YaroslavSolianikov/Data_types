using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_types_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;
            Console.WriteLine("Enter the number 1,2,3,4 or 5: ");
            int k = int.Parse(Console.ReadLine());
            switch (k)
            {
                case 1:
                Console.WriteLine(x += y - x++ * z); 
                    break; 
                case 2:
                Console.WriteLine(z = --x - y * 5); 
                    break;
                case 3:
                Console.WriteLine(y /= x + 5 % z); 
                    break;
                case 4:
                Console.WriteLine(z = x++ + y * 5); 
                    break;
                case 5: 
                Console.WriteLine(x = y - x++ * z); 
                    break;
            }
            Console.ReadKey();
        }
    }
}
