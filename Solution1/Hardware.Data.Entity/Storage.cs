using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Entity
{
    public class Storage:Abstract.Entity
    {
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public int CapacityId { get; set; }
        public virtual Numbers Capacity { get; set; }
        public int StorageTypeId { get; set; }
        public virtual StorageType StorageType { get; set; }
        public int CacheId { get; set; }
        public virtual Numbers Cache { get; set; }
        public int FormFactorId { get; set; }
        public virtual FormFactor FormFactor { get; set; }
        public int InterfaceId { get; set; }
        public virtual Interface Interface { get; set; }
    }
}
