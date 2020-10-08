using System;
using System.Collections;

namespace IEnumerableExample
{
    public class ArrayInv : IEnumerable, IEnumerator
    {
        Inventory[] invs = new Inventory[InitialData.Names.Length];
        int idx = -1;
        public ArrayInv()
        {
            for (int i = 0; i < InitialData.Names.Length; i++)
                invs[i] = new Inventory(InitialData.Names[i], InitialData.Costs[i],
                    InitialData.Onhands[i]);
        }

        public object Current { get { return invs[idx]; } }

        public IEnumerator GetEnumerator() { return this; }

        public bool MoveNext()
        {
            if (idx == invs.Length - 1)
            {
                Reset(); // reset enumerator at the end
                return false;
            }
            idx++;
            return true;
        }

        public void Reset()
        {
            idx = -1;
        }
    }
    public class MyClass : IEnumerable, IEnumerator
    {
        char[] chars = new char[] {'A','D','F','G','E'};
        int idx = -1;
        public object Current {
            get { return chars[idx];  }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (idx == chars.Length - 1)
            {
                Reset(); // reset enumerator at the end
                return false;
            }
            idx++;
            return true;
        }

        public void Reset()
        {
            idx = -1;// reset enumerator to the start
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            Console.WriteLine("\n\nDisplay the contents of mc");
            // Display the contents of mc
            foreach (char ch in mc)
                Console.Write(ch + " ");
            Console.WriteLine();
            // Display the contents of mc, again
            foreach (char ch in mc)
                Console.Write(ch + " ");
            Console.WriteLine("\n");

            ArrayInv ai = new ArrayInv();
            foreach(Inventory i in ai)
                Console.WriteLine("   " + i);
            Console.WriteLine("\n");
        }
    }
}
