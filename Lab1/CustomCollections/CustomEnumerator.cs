using System.Collections;

namespace CustomCollections
{
    internal class CustomEnumerator<T> : IEnumerator<T>
    {
        private readonly IList<T> _collection;
        private T _current;
        private int _index;

        public T Current => _current;

        object IEnumerator.Current => _current!;

        public CustomEnumerator(IList<T> collection)
        {
            _collection = collection;
            _index = -1;

            _current = _collection.Any() ? _collection[0] : default!;
        }

        public bool MoveNext()
        {
            _index++;

            if (_index < _collection.Count)
            {
                _current = _collection[_index];

                return true;
            }
            
            return false;
        }

        public void Reset()
        {
            _index = -1;

            if (_collection.Any())
            {
                _current = _collection[0];
            }
        }

        public void Dispose()
        {
            return;
        }
    }
}
