using System;
using System.Collections;
// A simple example of an iterator
namespace IteratorExample
{
    //example1
    class MyClass1
    {
        char[] chrs = { 'A', 'B', 'C', 'D' };
        // This iterator returns the characters
        // in the chrs array
        public IEnumerator GetEnumerator()
        {
            foreach (char ch in chrs)
                yield return ch;
        }
    }
    //example2
    class MyClass2
    {
        char ch = 'A';
        // This iterator returns the letters of the alphabet
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 26; i++)
                yield return (char)(ch + i);
        }
    }
    //example3
    class MyClass
    {
        char ch = 'A';
        // This iterator returns the first 10
        // letters of the alphabet.
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 26; i++)
            {
                if (i == 10) yield break; // stop iterator early
                yield return (char)(ch + i);
            }
        }
    }
    //example4
    class MyClass4
    {
        // This iterator returns the letters
        // A, B, C, D, and E
        public IEnumerator GetEnumerator()
        {
            yield return 'A';
            yield return 'B';
            yield return 'C';
            yield return 'D';
            yield return 'E';
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            //example1
            MyClass1 mc1 = new MyClass1();
            foreach (char ch in mc1)
                Console.Write(ch + " ");
            Console.WriteLine();

            //example2
            MyClass2 mc2 = new MyClass2();
            foreach (char ch in mc2)
                Console.Write(ch + " ");
            Console.WriteLine();

            //example3
            MyClass mc = new MyClass();
            foreach (char ch in mc)
                Console.Write(ch + " ");
            Console.WriteLine();

            //example4
            MyClass4 mc4 = new MyClass4();
            foreach (char ch in mc4)
                Console.Write(ch + " ");
            Console.WriteLine();
        }
    }
}

