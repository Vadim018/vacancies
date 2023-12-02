using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OO3
{
    internal class RoomServicePL : IRoomServicePL
    {
        IRoomServiceBLL roomServiceBLL;
        public RoomServicePL(IRoomServiceBLL roomServiceBLL)
        {
            this.roomServiceBLL = roomServiceBLL;
        }
        public void GetAllRooms()
        {
            List<Room> rooms = roomServiceBLL.GetAllRooms();

            foreach (Room r in rooms)
            {
                Console.WriteLine(r);
            }
        }
        public void GetRoomsByQuantity()
        {
            List<RoomFreePlacesVM> rooms = roomServiceBLL.GetRoomsAndQuantity();

            foreach (RoomFreePlacesVM roomFreePlacesVM in rooms) 
            {
                Console.WriteLine(roomFreePlacesVM);
            }
        }
    }
}