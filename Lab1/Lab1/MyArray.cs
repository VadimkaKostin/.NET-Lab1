using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class MyArray<T> : IList<T>
    {
        private int _defaultCapacity = 4;

        private int _count = 0;
        private int _capacity;
        private T[] _items;

        public int Count => _count;

        public bool IsReadOnly => false;

        public T this[int index] { get => _items[GetProperIndex(index)]; set => _items[GetProperIndex(index)] = value; }

        public MyArray()
        {
            _capacity = _defaultCapacity;
            _items = new T[_capacity];
        }

        public MyArray(int capacity)
        {
            _capacity = _defaultCapacity = capacity;
            _items = new T[_capacity];
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        #region PRIVATE METHODS
        private int GetProperIndex(int index) => index % _count;

        private void Resize()
        {
            _capacity *= 2;

            int[] tempArray = new int[_capacity];

            Array.Copy(_items, tempArray, _count);
        }
        #endregion
    }
}
