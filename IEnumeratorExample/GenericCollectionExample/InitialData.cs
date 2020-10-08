using System;
namespace IEnumerableExample
{
    public class InitialData
    {
        static string[] names = new string[] { "Pliers", "Wrenches", "Hammers", "Drills" };
        static double[] costs = new double[] { 15.50, 5.40, 25.0, 45.60 };
        static int[] onhands = new int[] { 5, 10, 2, 1 };
        public static string[] Names
        {
            get { return names; }
        }
        public static double[] Costs
        {
            get { return costs; }
        }
        public static int[] Onhands
        {
            get { return onhands; }
        }
    }
}
