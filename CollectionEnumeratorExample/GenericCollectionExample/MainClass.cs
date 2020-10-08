using System;
using System.Collections;

namespace EnumerableExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            ArrayList inv = new ArrayList();
            for (int i = 0; i < InitialData.Names.Length; i++)
                inv.Add(new Inventory(InitialData.Names[i], InitialData.Costs[i], InitialData.Onhands[i]));
            Console.WriteLine("Inventory list:");
            // Use enumerator to access list
            IEnumerator etrInv = inv.GetEnumerator();
            while (etrInv.MoveNext())
                Console.WriteLine(etrInv.Current + " ");
            Console.WriteLine();

            inv.Sort();//sorts by cost
            Console.WriteLine("Sorted by cost:");
            IEnumerator etrInv2 = inv.GetEnumerator();//error without this
            //because the Sort method modifies the collection
            while (etrInv2.MoveNext())
                Console.WriteLine(etrInv2.Current + " ");
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

            // Use enumerator to access list
            IEnumerator etr = charlist.GetEnumerator();
            while (etr.MoveNext())
                Console.Write(etr.Current + " ");
            Console.WriteLine();

            //charlist.Sort();//if we modify the collection we have to use another enumerator
            // Re–enumerate the list
            etr.Reset();
            while (etr.MoveNext())
                Console.Write(etr.Current + " ");
            Console.WriteLine();

        }
    }
}
