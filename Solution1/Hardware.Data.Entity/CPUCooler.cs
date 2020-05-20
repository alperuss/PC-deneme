using System;
using System.Collections.Generic;
using System.Text;
using Hardware.Data.Abstract;

namespace Hardware.Data.Entity
{
    public class CPUCooler:Bool
    {
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public int FanRPMId { get; set; }
        public virtual Numbers FanRpm { get; set; }
        public int NoiseId { get; set; }
        public virtual Numbers Noise { get; set; }
        public virtual ICollection<Socket> Sockets { get; set; }

    }
}
