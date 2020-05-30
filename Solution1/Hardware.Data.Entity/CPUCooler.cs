using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Hardware.Data.Abstract;

namespace Hardware.Data.Entity
{
    public class CPUCooler:BoolEntity
    {
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public int FanRPMId { get; set; }
        [ForeignKey("FanRPMId")]
        public virtual Numbers FanRpm { get; set; }
        public int NoiseId { get; set; }
        [ForeignKey("NoiseId")]
        public virtual Numbers Noise { get; set; }
        public virtual ICollection<Socket> Sockets { get; set; }

    }
}
