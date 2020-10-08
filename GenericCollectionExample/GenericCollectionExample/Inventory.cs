using System;
namespace GenericCollectionExample
{
    public class Inventory
    {
        string name;
        double cost;
        int onhand;
        public Inventory(string n, double c, int h)
        {
            name = n;
            cost = c;
            onhand = h;
        }
        public override string ToString()
        {
            return String.Format("{0,-10}Cost: {1,6:C}  On hand: {2}", name, cost, onhand);
        }
    }
}
