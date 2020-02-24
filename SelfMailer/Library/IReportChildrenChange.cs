using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMailer.Library
{
    interface IReportChildrenChange : IReportChange
    {
        void ChildChanged(object sender, ChangedEventArgs e);
    }
}
