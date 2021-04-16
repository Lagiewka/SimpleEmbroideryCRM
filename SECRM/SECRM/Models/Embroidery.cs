using System;
using System.Collections.Generic;

#nullable disable

namespace SECRM.Models
{
    public partial class Embroidery
    {
        public Embroidery()
        {
            EmbroideryColors = new HashSet<EmbroideryColor>();
        }

        public int EmbroideryId { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public int? StitchQty { get; set; }
        public decimal? ProgrammingPrice { get; set; }
        public decimal? FrontPrice { get; set; }
        public float? FrontHeight { get; set; }
        public float? FrontWidth { get; set; }
        public decimal? BackPrice { get; set; }
        public float? BackHight { get; set; }
        public float? BackWidth { get; set; }
        public string Observations { get; set; }
        public int ClientId { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<EmbroideryColor> EmbroideryColors { get; set; }
    }
}
