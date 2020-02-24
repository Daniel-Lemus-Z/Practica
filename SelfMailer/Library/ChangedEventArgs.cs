using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMailer.Library
{
    public class ChangedEventArgs : EventArgs
    {
        public bool HasChanged { get; protected set; }
        public ChangedEventArgs(bool hasChanged)
        {
            this.HasChanged = hasChanged;
        }
    }
}
