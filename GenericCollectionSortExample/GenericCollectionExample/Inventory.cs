using System;
using System.Collections.Generic;
namespace GenericCollectionExample
{
    public class Inventory: IComparable<Inventory>
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
        public static IComparer<Inventory> SortByName
        { get { return (IComparer<Inventory>)new InventoryComparer(); } }

        public int CompareTo(Inventory obj)
        {
            if (obj != null)
                return this.cost.CompareTo(obj.cost);
            else
                throw new ArgumentException("Parameter is not an Inventory!");
        }

        public override string ToString()
        {
            return String.Format("{0,-10}Cost: {1,6:C}  On hand: {2}", name, cost, onhand);
        }
    }
    class InventoryComparer : IComparer<Inventory>
    {
        int IComparer<Inventory>.Compare(Inventory o1, Inventory o2)
        {
            if (o1 != null && o2 != null)
                return string.Compare(o1.Name, o2.Name, StringComparison.Ordinal);
            else
                throw new ArgumentException("Parameter is not an Inventory!");
        }
    }
}
