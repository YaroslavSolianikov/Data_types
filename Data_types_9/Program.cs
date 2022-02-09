using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// #comment
/// Используя Visual Studio, создайте проект по шаблону Console Application.Напишите программу расчета объема - V и площади поверхности -S цилиндра.
/// Объем V цилиндра радиусом – R и высотой – h, вычисляется по формуле:  V=πr^2 h. Площадь S поверхности цилиндра вычисляется по формуле: S = 2πR(R+h).
/// Результаты расчетов выведите на экран.  Пользователь должен иметь возможность вводит r – радиус цилиндра и h – высоту цилинда.
/// </summary>
namespace Data_types_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            double h = double.Parse(Console.ReadLine());

            double s = (2 * Math.PI * r) * (r + h);
            double v = Math.PI * Math.Pow(r,2) * h;

            Console.WriteLine($"Square: {s}, Volume: {v}");
            Console.ReadKey();
        }
    }
}
