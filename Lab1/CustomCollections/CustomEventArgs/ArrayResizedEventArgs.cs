using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections.CustomEventArgs
{
    public class ArrayResizedEventArgs : ArrayEventArgs
    {
        public int OldCapacity { get; private set; }
        public int NewCapacity { get; private set; }

        public ArrayResizedEventArgs(int oldCapacity, int newCapacity) : base(ArrayAction.Resize)
        {
            OldCapacity = oldCapacity;
            NewCapacity = newCapacity;
        }
    }
}
