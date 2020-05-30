using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Entity
{
    public class Numbers
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public virtual ICollection<CPU> Cpus { get; set; }
        public virtual ICollection<CPUCooler> CpuCoolers { get; set; }
        public virtual ICollection<Motherboard> Motherboards { get; set; }
        public virtual ICollection<VideoCard> VideoCards{ get; set; }
        public virtual ICollection<PowerSupply> PowerSupplies{ get; set; }
        public virtual ICollection<RAM> Rams{ get; set; }
        public virtual ICollection<Storage> Storages{ get; set; }

    }
}
