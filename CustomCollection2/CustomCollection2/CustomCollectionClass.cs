using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomCollection2
{
    class CustomCollectionClass<T> : IEnumerator<T> where T : new()
    {
        // An array that stores data internally
        private readonly T[] vals = new T[3];
        //...
        public CustomCollectionClass()
        {
            vals[0] = new T();
            vals[1] = new T();
            vals[2] = new T();
        }
           
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        // An int object to hold the current position of the enumerator.
        private int pointer = -1;

        // Define a Current property to return the current item.
        // You should include validation to ensure that the pointer is
        // currently valid.
        public T Current
        {
            get
            {
                // Check that the state is valid.
                if (pointer != -1)
                {
                    return vals[pointer];
                }
                // Throw an exception if the current state is not valid.
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }


        // Implement the IDisposable interface and associated methods.
        public void Dispose() { }

        // Define a Current property for the IEnumerable interface.
        // Return the Current property from the type-safe generic
        // IEnumerator<T> interface.
        object IEnumerator.Current
        {
            get { return (object)Current; }
        }

        // Define a MoveNext method that advances the enumerator to the
        // next item in the collection.
        public bool MoveNext()
        {
            // You should check that the enumerator will not pass the end
            //of the collection if you advance it.
            if (pointer < (vals.Length - 1))
            {
                pointer++;
                // Return true if the enumerator successfully advances.
                return true;
            }
            else
            {
                // Return false if the enumerator will pass the end of the
                // collection if you advance it.
                return false;
            }
        }

        // Define a Reset method that restores the enumerator to the
        // initial state, before the first item.
        public void Reset()
        {
            pointer = -1;
        }
    }
}
