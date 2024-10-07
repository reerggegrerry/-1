using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину прямоугольника");
            double m = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширину");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону квадрата");
            double k = double.Parse(Console.ReadLine());

            double s = m*n;
            double ssquare = k*k;
            double answer = s / ssquare;
            Console.WriteLine("Количество квадратов: " + answer);
            Console.ReadKey();
        }
    }
}
//Дан прямоугольник m*n см. Сколько квадратов со стороной k от него можно отрезать. Вар9