using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OO3
{
    internal class MainMenu : IMenu
    {
        public bool Flag { get; set; }
        StrategyMenu menuStrategy;
        ConsoleColor defaultColor;
        public MainMenu(StrategyMenu menuStrategy)
        {
            this.menuStrategy = menuStrategy;
        }
        public void Init()
        {
            Flag = true;
            defaultColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("------------------------------");
            Console.WriteLine("INIT");
            Console.WriteLine("******************************");
        }
        public void Idle()
        {
            Console.WriteLine("1 - ROOMS");
            Console.WriteLine("2 - EXIT");
            Console.WriteLine("------------------------------");

            int menuChoose = int.Parse(Console.ReadLine());

            switch (menuChoose)
            {
                case 1:
                    menuStrategy.Run();
                    break;
                case 2:
                    Flag = false;
                    break;
                default:
                    Console.WriteLine("                                        ERROR! PLEASE, TRY AGAIN...");
                    break;
            }
        }
        public void CleanUp()
        {
            Console.ForegroundColor = defaultColor;
            Console.WriteLine("------------------------------");
            Console.WriteLine("CLEANUP");
            Console.WriteLine("------------------------------");
        }
    }
}