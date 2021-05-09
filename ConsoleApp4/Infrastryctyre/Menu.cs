using ConsoleApp4.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Infrastryctyre
{
    class Menu
    {
        public static void Start()
        {
            Calc calc = new Calc(new View.ConsoleView());

            while (true)
            {
                Console.WriteLine("Для суммы нажмите p\n\n ");
                Console.WriteLine("Для разности нажмите r\n\n ");
                Console.WriteLine("Для произведения нажмите m\n\n ");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.P:
                        calc.Sum();
                        break;
                    case ConsoleKey.R:
                        calc.Sub();
                        break;
                    case ConsoleKey.M:
                        calc.Mult();
                        break;
                    case ConsoleKey.Escape: return;
                }
            }
        }

    }
}
