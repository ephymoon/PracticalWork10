using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class Flat
    {
        public Room[] room_array;
        public int apt_room;
        public int floor;
        public Flat()
        {
            room_array = new Room[3];
            apt_room = 1;
            floor = 1;
        }
        public Flat(Room[] room_array, int apt_room, int floor)
        {
            this.room_array = room_array;
            this.apt_room = apt_room;
            this.floor = floor;
        }
        public Flat(Flat p1)
        {
            room_array = p1.room_array;
            apt_room = p1.apt_room;
            floor = p1.floor;
        }
        public override string ToString()
        {
            return string.Format("Квартира номер {0}, {1} комнат, {2} этаж.", apt_room, room_array.Length, floor);
        }
    }
}
