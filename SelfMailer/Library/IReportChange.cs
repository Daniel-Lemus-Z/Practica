using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMailer.Library
{
    public interface IReportChange
    {
        bool HasChanged
        {
            get;
            set;
        }
        event EventHandler<ChangedEventArgs> Changed;
    }
}
