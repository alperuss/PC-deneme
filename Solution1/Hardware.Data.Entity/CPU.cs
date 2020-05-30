using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hardware.Data.Entity
{
    public class CPU:Abstract.BoolEntity
    {
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public int CoreSeriesId { get; set; }
        public virtual CoreSeries CoreSeries { get; set; }
        public int CoreSpeedId { get; set; }
        public virtual CoreSpeed CoreSpeed { get; set; }
        public int CoreCountId { get; set; }
        [ForeignKey("CoreCountId")]
        public virtual Numbers CoreCount { get; set; }
        public int VoltageId { get; set; }
        [ForeignKey("VoltageId")]
        public virtual Numbers Voltage { get; set; }
        public int SocketId { get; set; }
        public virtual Socket Socket { get; set; }
        public int MaximumSupportedMemoryId { get; set; }
        [ForeignKey("MaximumSupportedMemoryId")]
        public virtual Numbers MaximumSupportedMemory { get; set; }
    }
}
