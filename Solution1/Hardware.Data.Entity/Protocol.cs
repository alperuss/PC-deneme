using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Entity
{
    public class Protocol
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<WirelessAdapter> WirelessAdapters { get; set; }

    }
}
