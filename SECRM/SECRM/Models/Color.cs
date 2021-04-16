using System;
using System.Collections.Generic;

#nullable disable

namespace SECRM.Models
{
    public partial class Color
    {
        public Color()
        {
            EmbroideryColors = new HashSet<EmbroideryColor>();
        }

        public int ColorId { get; set; }
        public string Name { get; set; }
        public string Catalog { get; set; }
        public string Code { get; set; }

        public virtual ICollection<EmbroideryColor> EmbroideryColors { get; set; }
    }
}
