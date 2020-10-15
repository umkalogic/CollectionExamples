using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCollectionExample
{
    public static class ConsoleMenu
    {
        public static void ListColors()
        {
            var colors = new AllColors();

            foreach (Color theColor in colors)
            {
                Console.Write(theColor.Name + " ");
            }
            Console.WriteLine();
            // Output: red blue green
        }
    }
}
