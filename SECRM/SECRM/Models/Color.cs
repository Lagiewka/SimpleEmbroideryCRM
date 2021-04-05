using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SECRM.Models
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Catalog { get; set; }
        public string Number { get; set; }

        public ICollection<EmbroideryColor> EmbroideryColors { get; set; }
    }
}
