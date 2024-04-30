using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class Building
    {
        public Flat[] apt_array;
        public int floors;
        public string address;
        public Building()
        {
            apt_array = new Flat[3];
            floors = 5;
            address = "ул. Пушкина 52";
        }
        public Building(Flat[] apt_array, int floors, string address)
        {
            this.apt_array = apt_array;
            this.floors = floors;
            this.address = address;
        }
        public Building(Building p1)
        {
            apt_array = p1.apt_array;
            floors = p1.floors;
            address = p1.address;
        }
        public override string ToString()
        {
            return string.Format("Здание по адресу {0}, {1} этажей, {2} квартир.", address, floors, apt_array.Length);
        }
    }
}
