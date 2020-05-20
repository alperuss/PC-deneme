using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Entity
{
    public class Module
    {
        public int Id { get; set; }
        public string ModuleNumber { get; set; }
        public virtual ICollection<RAM> Rams { get; set; }
    }
}
