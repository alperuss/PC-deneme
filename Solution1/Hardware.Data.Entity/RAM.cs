using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Hardware.Data.Abstract;

namespace Hardware.Data.Entity
{
    public class RAM:BoolEntity
    {
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public int MemorySpeedId { get; set; }
        public virtual MemorySpeed MemorySpeed { get; set; }
        public int MemoryTypeId { get; set; }
        public virtual MemoryType MemoryType { get; set; }
        public int ModuleId { get; set; }
        public virtual Module Module { get; set; }
        public int CASLatencyId { get; set; }
        [ForeignKey("CASLatencyId")]
        public virtual Numbers CasLatency { get; set; }
        public int VoltageId { get; set; }
        [ForeignKey("VoltageId")]
        public virtual Numbers Voltage { get; set; }
    }
}
