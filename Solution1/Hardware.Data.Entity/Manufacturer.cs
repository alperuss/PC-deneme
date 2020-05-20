using System;
using System.Collections.Generic;
using System.Text;
using Hardware.Data.Entity;

namespace Hardware.Data.Entity
{
    public class Manufacturer:Abstract.Entity
    {
        public string Name { get; set; }
        public virtual ICollection<CPU> CPUs { get; set; }
        public virtual ICollection<CPUCooler> CpuCoolers { get; set; }
        public virtual ICollection<Motherboard> Motherboards { get; set; }
        public virtual ICollection<RAM> Rams { get; set; }
        public virtual ICollection<Storage> Storages { get; set; }
        public virtual ICollection<VideoCard> VideoCards { get; set; }
        public virtual ICollection<Case> Cases { get; set; }
        public virtual ICollection<PowerSupply> PowerSupplies { get; set; }
        public virtual ICollection<WirelessAdapter> WirelessAdapters { get; set; }
    }
}
