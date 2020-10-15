using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomCollection2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomCollectionClass<int> asd = new CustomCollectionClass<int>();
            foreach (var n in asd)
            {
                Console.WriteLine(n);
            }

            CustomCollectionClass<Person> colPersons = new CustomCollectionClass<Person>();
            foreach (var n in colPersons)
            {
                Console.WriteLine(n);
            }
        }
    }
}