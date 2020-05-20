using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Entity
{
    public class Socket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<CPU> Cpus { get; set; }
        public virtual ICollection<CPUCooler> CpuCoolers { get; set; }
        public virtual ICollection<Motherboard> Motherboards { get; set; }

    }
}
