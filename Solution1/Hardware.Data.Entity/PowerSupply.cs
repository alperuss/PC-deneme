using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Hardware.Data.Abstract;

namespace Hardware.Data.Entity
{
    public class PowerSupply:BoolEntity
    {

        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public int FormFactorId { get; set; }
        public virtual FormFactor FormFactor { get; set; }
        public int EfficiencyRatingId { get; set; }
        public virtual EfficiencyRating EfficiencyRating { get; set; }
        public int VoltageId { get; set; }
        [ForeignKey("VoltageId")]
        public virtual Numbers Voltage { get; set; }
        
    }
}
