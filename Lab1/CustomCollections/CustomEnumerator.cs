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
            _index = 0;

            _current = _collection.Any() ? _collection[0] : default!;
        }

        private bool HasNext() => _index < _collection.Count - 1;

        public bool MoveNext()
        {
            if (!HasNext()) 
                return false;

            _current = _collection[++_index];
            return HasNext();
        }

        public void Reset()
        {
            _index = 0;

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
