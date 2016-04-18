using System;

namespace Week13A_3_SortString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string s = "Microsoft .NET Framework 2.0 Application Development Foundation";
            string[] sa = s.Split(' ');

            Array.Sort(sa);

            s = string.Join(" ", sa);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
