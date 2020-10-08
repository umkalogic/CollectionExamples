using System;
using System.Collections.Generic;

namespace GenericCollectionExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Inventory> inv = new List<Inventory>();
            for (int i = 0; i < InitialData.Names.Length; i++)
                inv.Add(new Inventory(InitialData.Names[i], InitialData.Costs[i], InitialData.Onhands[i]));
            Console.WriteLine("Inventory list:");
            foreach (Inventory i in inv)
                Console.WriteLine("   " + i);
            //inv.Sort();//Error without the IComparable
            char[] chs = new char[] { 'B', 'K', 'L', 'A', 'E' };
            List<char> charlist = new List<char>();
            for (int i = 0; i < 5; i++)
                charlist.Add(chs[i]);
            Console.WriteLine("Char list:");
            foreach (char i in charlist)
                Console.Write("   " + i);
            Console.WriteLine();
            charlist.Sort();
            foreach (char i in charlist)
                Console.Write("   " + i);
        }
    }
}
