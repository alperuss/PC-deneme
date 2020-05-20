using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Entity
{
    public class VideoCard
    {
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public int ChipsetId { get; set; }
        public virtual Chipset Chipset { get; set; }
        public int CapacityId { get; set; }
        public virtual Numbers Capacity { get; set; }
        public int MemoryTypeId { get; set; }
        public virtual MemoryType MemoryType { get; set; }
        public int CoreSpeedId { get; set; }
        public virtual CoreSpeed CoreSpeed { get; set; }
        public int VoltageId { get; set; }
        public virtual Numbers Voltage { get; set; }
        public int InterfaceId { get; set; }
        public virtual Interface Interface { get; set; }
    }
}
