using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMailer.CodeFirst
{
    public class SMContext : DbContext
    {
        public DbSet<MailServer> MailServers { get; set; }

        public DbSet<Sender> Senders { get; set; }
    }
}
