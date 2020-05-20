using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Entity
{
    public class Interface
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Storage> Storages { get; set; }
        public virtual ICollection<VideoCard> VideoCards { get; set; }
        public virtual ICollection<WirelessAdapter> WirelessAdapters { get; set; }
    }
}
