using System;
using System.Collections.Generic;
using System.Text;
using Hardware.Data.Interface.UnitOfWork;

namespace Hardware.Data.Interface
{
    public interface ICPURepository : IRepository<Data.Entity.CPU>
    {
    }
}
