using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OO3
{
    internal class RoomFreePlacesVM
    {
        public string RoomName { get; set; }
        public int QuantityRoom { get; set; }
        public RoomFreePlacesVM(string roomName, int quantityRoom) 
        {
            RoomName = roomName;
            QuantityRoom = quantityRoom;
        }
        public override string ToString()
        {
            return String.Format("NAME: " + RoomName + " " + "VACANCIES: " + QuantityRoom);
        }
    }
}