using System;
using System.Collections.Generic;
using System.Text;
using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class CPURepository : Repository<Data.Entity.CPU>, Data.Interface.ICPURepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public CPURepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
