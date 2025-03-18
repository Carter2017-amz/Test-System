using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailManager.Models
{
    public class Message
    {
        public int ID { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public DateTime SendDate { get; set; }
        public int ContactID { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
