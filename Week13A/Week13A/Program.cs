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

            Console.WriteLine(jozsi);
            Console.WriteLine(pakko);
            Console.ReadKey();
        }
    }
}
