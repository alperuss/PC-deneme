using System;
using System.Collections.Generic;
using System.Text;
using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class CPUCoolerRepository : Repository<Data.Entity.CPUCooler>, Data.Interface.ICPUCoolerRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public CPUCoolerRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
