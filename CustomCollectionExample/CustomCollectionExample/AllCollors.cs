using System.Collections;

namespace CustomCollectionExample
{
    // Custom collection class
    public class AllColors : IEnumerable
    {
        Color[] _colors =
        {
            new Color() { Name = "red" },
            new Color() { Name = "green" },
            new Color() { Name = "blue" }
        };

        public IEnumerator GetEnumerator()
        {
            return new ColorEnumerator(_colors);

            // Instead of creating a custom enumerator, you could
            // use the GetEnumerator of the array.
            //return _colors.GetEnumerator();
        }

        // Custom enumerator
        private class ColorEnumerator : IEnumerator
        {
            private Color[] _colors;
            private int _position = -1;

            public ColorEnumerator(Color[] colors)
            {
                _colors = colors;
            }

            object System.Collections.IEnumerator.Current
            {
                get
                {
                    return _colors[_position];
                }
            }

            bool IEnumerator.MoveNext()
            {
                _position++;
                return (_position < _colors.Length);
            }

            void IEnumerator.Reset()
            {
                _position = -1;
            }
        }
    }
}
