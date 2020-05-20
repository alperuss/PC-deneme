using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Entity
{
    public class CoreSpeed
    {
        public int Id { get; set; }
        public int CoreClock { get; set; }
        public int? BoostClock { get; set; }
        public virtual ICollection<CPU> Cpus { get; set; }
        public virtual ICollection<VideoCard> VideoCards { get; set; }
    }
}
