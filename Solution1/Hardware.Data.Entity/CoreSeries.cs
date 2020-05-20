using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Entity
{
    public class CoreSeries
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<CPU> Cpus { get; set; }
    }
}
