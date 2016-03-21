using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13A
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jozsi = new Person("Boda Jozsi", new DateTime(1975, 1, 1));
            Person pakko = new Person("Monoczki Pakko", new DateTime(1980, 1, 15));
            Employee atesz = new Employee("Molnar Atesz", new DateTime(1989, 5, 6), 1000000, "Software engineer");
            atesz.Room = new Room(111);
            atesz.Room.Number = 1;

            Console.WriteLine(jozsi);
            Console.WriteLine(pakko);
            Console.WriteLine(atesz);
            Console.ReadKey();
        }
    }
}
