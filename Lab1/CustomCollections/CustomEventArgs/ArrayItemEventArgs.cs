using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections.CustomEventArgs
{
    public class ArrayItemEventArgs<T> : ArrayEventArgs
    {
        public T Item { get; }
        public int Index { get; }

        public ArrayItemEventArgs(T item, int index, ArrayAction action) : base(action)
        {
            Item = item;
            Index = index;
        }
    }
}
