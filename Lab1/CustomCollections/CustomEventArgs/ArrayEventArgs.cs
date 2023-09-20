using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections.CustomEventArgs
{
    public class ArrayEventArgs : EventArgs
    {
        public ArrayAction Action { get; private set; }
        public DateTime ActionDateTime { get; private set; }
        
        public ArrayEventArgs(ArrayAction action)
        {
            Action = action;
            ActionDateTime = DateTime.Now;
        }
    }
}
