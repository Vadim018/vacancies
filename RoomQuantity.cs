using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OO3
{
    internal class RoomQuantity : IID
    {
        public int Id { get; set; }
        public int QuantityRoom { get; set; }    
        public int RoomId { get; set; }

        public RoomQuantity(int quantityRoom, int roomId)
        {
            QuantityRoom = quantityRoom;
            RoomId = roomId;
        }
        public override string ToString()
        {
            return String.Format("VACANCIES: " + QuantityRoom + " " + "NUMBER: " + RoomId);
        }
    }
}