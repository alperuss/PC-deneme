using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Entity
{
    public class Case : Abstract.BoolEntity
    {
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        //public int SidePanelWindowId { get; set; }
        //public virtual SidePanelWindow SidePanelWindow { get; set; }
        public virtual ICollection<FormFactor> FormFactors { get; set; }
        
    }
}
