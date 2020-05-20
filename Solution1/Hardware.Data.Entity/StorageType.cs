using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Entity
{
    public class StorageType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Storage> Storages { get; set; }

    }
}
