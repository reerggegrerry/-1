using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace дз1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Отрывок А.С.Пушкина");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Унылая пора! Очей очарованье!");
            Console.WriteLine("Приятна мне твоя прощальная краса —");
            Console.WriteLine("Люблю я пышное природы увяданье,");
            Console.WriteLine("В багрец и в золото одетые леса,");
            Console.WriteLine("В их сенях ветра шум и свежее дыханье,");
            Console.WriteLine("И мглой волнистою покрыты небеса,");
            Console.WriteLine("И редкий солнца луч, и первые морозы,");
            Console.WriteLine("И отдаленные седой зимы угрозы.");
            Console.ResetColor();   
            Console.ReadKey();
        }
    }
}
