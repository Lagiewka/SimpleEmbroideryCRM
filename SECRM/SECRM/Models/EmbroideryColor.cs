using System;
using System.Collections.Generic;

#nullable disable

namespace SECRM.Models
{
    public partial class EmbroideryColor
    {
        public int EmbroideryColorId { get; set; }
        public int EmbroideryId { get; set; }
        public int ColorId { get; set; }
        public int Position { get; set; }

        public virtual Color Color { get; set; }
        public virtual Embroidery Embroidery { get; set; }
    }
}
