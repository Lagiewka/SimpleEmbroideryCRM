using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SECRM.Models
{
    public class EmbroideryColor
    {
        public int EmbroideryColorId { get; set; }
        public int EmbroideryId { get; set; }
        public Embroidery Embroidery { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public int Order { get; set; }



    }
}
