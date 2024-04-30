using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{

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
            Room room3 = new Room();
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
            Flat flat3 = new Flat();
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
