using System;
using System.Collections.Generic;
using System.Text;
using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class CaseRepository : Repository<Data.Entity.Case>, Data.Interface.ICaseRepository
    {
        private readonly Data.Context.DataContext _dataContext;
        public CaseRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
