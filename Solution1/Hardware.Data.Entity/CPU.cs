using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Entity
{
    public class CPU:Abstract.Bool
    {
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public int CoreSeriesId { get; set; }
        public virtual CoreSeries CoreSeries { get; set; }
        public int CoreSpeedId { get; set; }
        public virtual CoreSpeed CoreSpeed { get; set; }
        public int CoreCountId { get; set; }
        public virtual Numbers CoreCount { get; set; }
        public int VoltageId { get; set; }
        public virtual Numbers Voltage { get; set; }
        public int SocketId { get; set; }
        public virtual Socket Socket { get; set; }
        public int MaximumSupportedMemoryId { get; set; }
        public virtual Numbers MaximumSupportedMemory { get; set; }
    }
}
