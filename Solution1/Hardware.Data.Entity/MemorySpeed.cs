using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Entity
{
    public class MemorySpeed
    {
        public int Id { get; set; }
        public int Speed { get; set; }
        public virtual ICollection<Motherboard> Motherboards { get; set; }
        public virtual ICollection<RAM> Rams { get; set; }

    }
}
