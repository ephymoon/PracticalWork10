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
            height= 2;
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

    internal class Program
    {

        static void Main(string[] args)
        {
            Room room = new Room();
            Flat flat = new Flat();
            Building build = new Building();
            // class Room
            Console.Write("Класс комнат.\nДлина комнаты: ");
            room.lenght = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ширина комнаты: ");
            room.width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Высота комнаты: ");
            room.height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Назначение комнаты: ");
            room.purpose = Console.ReadLine();
            Console.Write("Демонстрация метода ToString: " + room.ToString());
            Room room2 = new Room(room);
            Room room3 = new Room(room2);
            Room[] xd = new Room[3];
            xd[0] = room;
            xd[1] = room2;
            xd[2] = room3;
            // class Flat
            flat.room_array = xd;
            Console.Write("\n\nКласс Квартир.\n");
            Console.Write("Номер квартиры: ");
            flat.apt_room = Convert.ToInt32(Console.ReadLine());
            Console.Write("Этаж: ");
            flat.floor = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nДемонстрация метода ToString: " + flat.ToString());
            Flat flat2 = new Flat(flat);
            Flat flat3 = new Flat(flat2);
            Flat[] xd2 = new Flat[3];
            xd2[0] = flat;
            xd2[1] = flat2;
            xd2[2] = flat3;
            build.apt_array = xd2;
            // class build
            Console.Write("\n\nКласс Зданий.\n");
            Console.Write("Количество этажей: ");
            build.floors = Convert.ToInt32(Console.ReadLine());
            Console.Write("Адрес: ");
            build.address = Console.ReadLine();
            Console.Write("\nДемонстрация метода ToString: " + build.ToString());
            Console.WriteLine();
            Console.Write("Для завершения работы программы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
