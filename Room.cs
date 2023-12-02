using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace OO3
{
    internal class Room : IID
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Room(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return String.Format("                                        " + "ID: " + Id + "   |   " + "ROOM: " + Name);
        }
    }
}