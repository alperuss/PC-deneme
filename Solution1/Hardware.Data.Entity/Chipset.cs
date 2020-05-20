using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Entity
{
    public class Chipset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Motherboard> Motherboards { get; set; }
        public virtual ICollection<VideoCard> VideoCards { get; set; }
    }
}
