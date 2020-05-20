using System;
using System.Collections.Generic;
using System.Text;
using Hardware.Data.Abstract;

namespace Hardware.Data.Entity
{
    public class Motherboard:Bool
    {
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public int ChipsetId { get; set; }
        public virtual Chipset Chipset { get; set; }
        public int SocketId { get; set; }
        public virtual Socket Socket { get; set; }
        public int FormFactorId { get; set; }
        public virtual FormFactor FormFactor { get; set; }
        public int MemoryMaxId { get; set; }
        public virtual MemoryMax MemoryMax { get; set; }
        public virtual MemoryType MemoryType { get; set; }
        public virtual ICollection<MemorySpeed> MemorySpeeds { get; set; }
    }
}
