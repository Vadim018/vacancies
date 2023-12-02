using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OO3
{
    internal class RoomServiceBLL : IRoomServiceBLL
    {
        IDBItemDAL<Room> dbRoom;
        IDBItemDAL<RoomQuantity> dbRoomQuantity;
        public RoomServiceBLL(IDBItemDAL<Room> dbRoom, IDBItemDAL<RoomQuantity> dbRoomQuantity)
        {
            this.dbRoom = dbRoom;
            this.dbRoomQuantity = dbRoomQuantity;
        }
        public List<Room> GetAllRooms()
        {
            return dbRoom.Items;
        }
        public List<RoomFreePlacesVM> GetRoomsAndQuantity()
        {
            List<RoomFreePlacesVM> roomFreePlacesVMs = new List<RoomFreePlacesVM>();

            foreach (Room r in dbRoom.Items)
            {
                foreach (RoomQuantity rq in dbRoomQuantity.Items)
                {
                    if (r.Id == rq.RoomId)
                    {
                        RoomFreePlacesVM roomFreePlacesVM = new RoomFreePlacesVM(r.Name, rq.QuantityRoom);
                        roomFreePlacesVMs.Add(roomFreePlacesVM);
                    }
                }
            }
            return roomFreePlacesVMs;
        }
    }
}