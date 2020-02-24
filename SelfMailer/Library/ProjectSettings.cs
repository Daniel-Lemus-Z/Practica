using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMailer.Library
{
    public class ProjectSettings : IReportChange
    {
        protected bool hasChanged;

        public bool HasChanged
        {
            get { return hasChanged; }
            set
            {
                if (this.hasChanged != value)
                {
                    this.hasChanged = value;
                    if (this.Changed != null)
                        this.Changed(this, new ChangedEventArgs(this.hasChanged));
                }
            }
        }

        public event EventHandler<ChangedEventArgs> Changed;
    }
}
