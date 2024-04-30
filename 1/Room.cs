using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class Room
    {
        public float lenght;
        public float width;
        public float height;
        public string purpose;
        // конструкторы
        public Room()
        {
            lenght = 10;
            width = 10;
            height = 2;
            purpose = "ничего";
        }
        public Room(float lenght, float width, float height, string purpose)
        {
            this.lenght = lenght; // this - ссылка на текущий экземпляр класса
            this.width = width;
            this.height = height;
            this.purpose = purpose;
        }
        public Room(Room p1)
        {
            lenght = p1.lenght;
            width = p1.width;
            height = p1.height;
            purpose = p1.purpose;
        }
        public override string ToString()
        {
            return string.Format("Комната {0}x{1}x{2}, для {3}", lenght, width, height, purpose);
        }
    }
}
