using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Entity
{
    public class MemoryMax
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public virtual ICollection<Motherboard> Motherboards { get; set; }

    }
}
