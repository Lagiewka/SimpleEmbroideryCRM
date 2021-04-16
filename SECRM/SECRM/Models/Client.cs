using System;
using System.Collections.Generic;

#nullable disable

namespace SECRM.Models
{
    public partial class Client
    {
        public Client()
        {
            Embroideries = new HashSet<Embroidery>();
        }

        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Machine { get; set; }

        public virtual ICollection<Embroidery> Embroideries { get; set; }
    }
}
