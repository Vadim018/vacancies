/*
-------------------------------------------------------------------------------------------------------------------
Завдання ОО3
-------------------------------------------------------------------------------------------------------------------
Створити трирівневу інформаційну систему з підтримки діяльності підприємства.
Існують декілька приміщень. В кожному приміщення є певна кількість вільних робочих місць. 
Ця інформація зберігається окремо від інформації щодо приміщень.
Наприклад:
   * приміщення1: (2 вільних робочих місця)
   * приміщення2: (4 вільних робочих місця)
  Інформаційна система повинна:
  1 - вивести всі приміщення, де кожне приміщення зі своєю кількістю вільних робочих місць.
  2 - по введеній кількості вільних робочих місць знайти перелік приміщень з такою кількістю вільних робочих місць.
-------------------------------------------------------------------------------------------------------------------
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OO3
{
    class Program
    {
        static void Main(string[] args)
        {
            IDBItemDAL<Room> dbRoom = new DBItemDAL<Room>();
            
            Room room1 = new Room("MANAGER");
            dbRoom.Add(room1);

            Room room2 = new Room("CEO");
            dbRoom.Add(room2);

            Room room3 = new Room("COOKER");
            dbRoom.Add(room3);

            IDBItemDAL<RoomQuantity> dbRoomQuantity = new DBItemDAL<RoomQuantity>();

            RoomQuantity roomQuantity1 = new RoomQuantity(2, 3);
            dbRoomQuantity.Add(roomQuantity1);

            RoomQuantity roomQuantity2 = new RoomQuantity(4, 2);
            dbRoomQuantity.Add(roomQuantity2);

            RoomQuantity roomQuantity3 = new RoomQuantity(6, 1);
            dbRoomQuantity.Add(roomQuantity3);

            IRoomServiceBLL roomServiceBLL = new RoomServiceBLL(dbRoom, dbRoomQuantity);

            IRoomServicePL roomServicePL = new RoomServicePL(roomServiceBLL);

            IMenu roomMenu = new RoomMenu(roomServicePL);

            StrategyMenu roomStrategy = new StrategyMenu(roomMenu);

            IMenu mainMenu = new MainMenu(roomStrategy);

            StrategyMenu mainMenuStrategy = new StrategyMenu(mainMenu);

            mainMenuStrategy.Run();

            Console.ReadKey();
        }
    }
}