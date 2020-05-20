using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Abstract
{
    public class Bool:Abstract.Entity
    {
        public bool ECC { get; set; }
        public bool HasFan { get; set; }
        public bool CpuCooler { get; set; }
        public bool Power { get; set; }
        public bool SMT { get; set; }
      

    }
}
