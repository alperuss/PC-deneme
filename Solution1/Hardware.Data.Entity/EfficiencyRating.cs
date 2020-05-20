using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Entity
{
    public class EfficiencyRating
    {
        public int Id { get; set; }
        public string Efficiency { get; set; }
        public virtual ICollection<PowerSupply> PowerSupplies { get; set; }
    }
}
