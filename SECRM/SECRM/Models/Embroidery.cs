using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace SECRM.Models
{
    public class Embroidery
    {
        [Key]
        public int EmbroideryId { get; set; }
        [Required]
        public byte[] Image { get; set; }
        [Required]
        public string Name { get; set; }
        public int StitchesQty { get; set; }
        public double ProgrammingPrice { get; set; }
        public double FrontPrice { get; set; }
        public double BackPrice { get; set; }
        public int FrontHight { get; set; }
        public int FrontWidth { get; set; }
        public int BackHeight { get; set; }
        public int BackWidth { get; set; }
        public string Observations { get; set; }

        public ICollection<EmbroideryColor> EmbroideryColors { get; set; }
    }
}
