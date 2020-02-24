using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMailer.CodeFirst
{
    public class Sender
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public virtual ICollection<MailServer> MailServers { get; set; }
    }
}
