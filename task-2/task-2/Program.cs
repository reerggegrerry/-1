using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите первый угол при стороне");
            double alpha = Math.PI * double.Parse(Console.ReadLine()) / 180;

            Console.WriteLine("Введите второй угол при стороне");
            double beta = Math.PI * double.Parse(Console.ReadLine()) / 180;

            double s = (a*a*Math.Sin(alpha)) / (2*Math.Sin(alpha+beta));
            Console.WriteLine("Площадь: " + s);
            Console.ReadKey();
            //найти площадь треугольника по стороне и двум углам. Вар9
        }
    }
}
