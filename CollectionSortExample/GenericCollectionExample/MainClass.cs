using System;
using System.Collections;

namespace NonGenericCollectionExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ArrayList inv = new ArrayList();
            for (int i = 0; i < InitialData.Names.Length; i++)
                inv.Add(new Inventory(InitialData.Names[i], InitialData.Costs[i], InitialData.Onhands[i]));
            Console.WriteLine("Inventory list:");
            foreach (Inventory i in inv)
                Console.WriteLine("   " + i);
            Console.WriteLine();

            inv.Sort();//sorts by cost
            Console.WriteLine("Sorted by cost:");
            foreach (Inventory i in inv)
                Console.WriteLine("   " + i);
            Console.WriteLine();

            inv.Sort(Inventory.SortByName);
            Console.WriteLine("Sorted by name:");
            foreach (Inventory i in inv)
                Console.WriteLine("   " + i);

            char[] chs = new char[] { 'B', 'K', 'L', 'A', 'E' };
            ArrayList charlist = new ArrayList();
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
