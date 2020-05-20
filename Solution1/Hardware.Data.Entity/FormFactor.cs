using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Entity
{
    public class FormFactor
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Motherboard> Motherboards { get; set; }
        public virtual ICollection<Storage> Storages { get; set; }
        public virtual ICollection<Case> Cases { get; set; }
        public virtual ICollection<PowerSupply> PowerSupplies { get; set; }
    }
}
