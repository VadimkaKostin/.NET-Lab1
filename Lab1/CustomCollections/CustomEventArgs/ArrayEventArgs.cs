using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections.CustomEventArgs
{
    public class ArrayEventArgs : EventArgs
    {
        public ArrayAction Action { get; }
        public DateTime ActionDateTime { get; }
        
        public ArrayEventArgs(ArrayAction action)
        {
            Action = action;
            ActionDateTime = DateTime.Now;
        }
    }
}
