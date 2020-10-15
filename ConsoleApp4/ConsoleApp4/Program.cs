using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var trainings = new TrainingsCollection<Training>();
            trainings.Add(new Training { Name = "C#", Cost = 10 });
            trainings.Add(new Training() { Name = "Java", Cost = 10 });

            // This loop with trigger to IEnumerator<T> GetEnumerator() from our custom TraningsEnumerator
            foreach (var item in trainings)
            {
                Console.WriteLine($"Traning Name {item.Name} and cost {item.Cost}");
            }

            Console.ReadKey();
        }
    }

    public class Company
    {
        public Company()
        {
            this.Trainings = new Trainings();
        }

        public Trainings Trainings { get; set; }

    }

    public class Training
    {
        public string Name { get; set; }

        public int Cost { get; set; }
    }

    public class Trainings : Collection<Training>
    {
        public Training this[string name]
        {
            get { return this.Items.First(s => string.Equals(s.Name, name, StringComparison.OrdinalIgnoreCase)); }
        }

        public IEnumerable<string> All => this.Items.Select(s => s.Name);

        protected override void InsertItem(int index, Training item)
        {
            // validation before adding in common place.
            if (item.Cost > 0)
            {
                base.InsertItem(index, item);
            }
        }

        public void ForEach(Action<string> action)
        {
            foreach (var item in Items)
            {
                action($"Traning Name {item.Name} and cost {item.Cost}");
            }
        }
    }

    public class TrainingsCollection<T> : ICollection<T> where T : Training
    {
        public TrainingsCollection()
        {
            List = new List<T>();
        }

        protected IList List { get; }

        public T this[int index] => (T)List[index];

        public int Count => this.List.Count;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            if (!string.IsNullOrEmpty(item.Name))
            {
                this.List.Add(item);
            }
        }

        public void Clear()
        {
            this.List.Clear();
        }

        public bool Contains(T item)
        {
            return this.List.Contains(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new TraningsEnumerator<T>(this);
        }

        public bool Remove(T item)
        {
            if (item != null && Contains(item))
            {
                this.List.Remove(item);
                return true;
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new TraningsEnumerator<T>(this);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            this.List.CopyTo(array, arrayIndex);
        }

        public void ForEach(Action<string> action)
        {
            foreach (var item in List.OfType<T>())
            {
                action($"Traning Name {item.Name} and cost {item.Cost}");
            }
        }
    }

    public class TraningsEnumerator<T> : IEnumerator<T> where T : Training
    {
        private readonly TrainingsCollection<T> collection;
        public int Counter = -1;

        public TraningsEnumerator(TrainingsCollection<T> collection)
        {
            this.collection = collection;
        }

        public object Current => collection[Counter];

        T IEnumerator<T>.Current => collection[Counter];

        public void Dispose()
        {
            Counter = -1;
        }

        public bool MoveNext()
        {
            ++Counter;
            if (collection.Count >  Counter)
            {
                return true;
            }

            return false;
        }

        public void Reset()
        {
            Counter = -1;
        }
    }
}
