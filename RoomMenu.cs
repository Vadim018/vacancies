using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OO3
{
    internal class RoomMenu : IMenu
    {
        public bool Flag { get; set; }
        IRoomServicePL roomServicePL;
        ConsoleColor defaultColor;
        public RoomMenu(IRoomServicePL roomServicePL)
        {
            this.roomServicePL = roomServicePL;
        }
        public void Init()
        {
            Flag = true;
            defaultColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("------------------------------");
            Console.WriteLine("INIT");
            Console.WriteLine("******************************");
        }
        public void Idle()
        {
            Console.WriteLine("1 - GET");
            Console.WriteLine("2 - FIND");
            Console.WriteLine("3 - EXIT");
            Console.WriteLine("------------------------------");

            int menuChoose = int.Parse(Console.ReadLine());

            switch (menuChoose)
            {
                case 1:
                    roomServicePL.GetAllRooms();
                    break;
                case 2:
                    roomServicePL.GetRoomsByQuantity();
                    break;
                case 3:
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