using System;
using System.Collections;
namespace NonGenericCollectionExample
{
    public class Inventory: IComparable
    {
        string name;
        double cost;
        int onhand;
        public string Name { get { return name; } }
        public Inventory(string n, double c, int h)
        {
            name = n;
            cost = c;
            onhand = h;
        }
        public static IComparer SortByName
        { get { return (IComparer)new InventoryComparer(); } }

        public int CompareTo(object obj)
        {
            Inventory t = obj as Inventory;
            if (obj != null)
                return this.cost.CompareTo(t.cost);
            else
                throw new ArgumentException("Parameter is not an Inventory!");
        }

        public override string ToString()
        {
            return String.Format("{0,-10}Cost: {1,6:C}  On hand: {2}", name, cost, onhand);
        }
    }
    class InventoryComparer : IComparer
    {
        int IComparer.Compare(object o1, object o2)
        {
            Inventory t1 = o1 as Inventory;
            Inventory t2 = o2 as Inventory;
            if (t1 != null && t2 != null)
                return string.Compare(t1.Name, t2.Name, StringComparison.Ordinal);
                //Compare strings using ordinal (binary) sort rules.
            else
                throw new ArgumentException("Parameter is not an Inventory!");
        }
    }
}
