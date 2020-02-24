using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMailer.CodeFirst
{
    public class MailServer
    {
        [Key]
        public int Id { get; set; }

        public string Host { get; set; }

        public string Username { get; set; }

        public Password Password { get; set; }

        public virtual ICollection<Sender> Senders { get; set; }
    }

    public class Password
    {
        public string value { get; set; }

        public bool AllowSave { get; set; }
    }
}
