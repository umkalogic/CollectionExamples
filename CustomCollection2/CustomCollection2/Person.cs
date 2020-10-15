using System;

namespace CustomCollection2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "Noname";
            Age = 18;
        }
        public override string ToString()
        {
            return String.Format("Name: {0}, Age: {1}", Name, Age);
        }
    }
}
