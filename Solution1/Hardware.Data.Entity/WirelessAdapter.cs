using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Entity
{
    public class WirelessAdapter
    {
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public int ProtocolId { get; set; }
        public virtual Protocol Protocol { get; set; }
        public int InterfaceId { get; set; }
        public virtual Interface Interface { get; set; }
    }
}
