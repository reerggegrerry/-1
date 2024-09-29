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
            Console.WriteLine("Отрывок А.С.Пушкина",
                ConsoleColor.Green);
            Console.WriteLine("Унылая пора! Очей очарованье!"
            "Приятна мне твоя прощальная краса —"
            "Люблю я пышное природы увяданье,"
            "В багрец и в золото одетые леса,"
            "В их сенях ветра шум и свежее дыханье,"
            "И мглой волнистою покрыты небеса,"
            "И редкий солнца луч, и первые морозы,"
            "И отдаленные седой зимы угрозы.",
            ConsoleColor.Yellow);
            Console.ReadKey();
        }
    }
}
