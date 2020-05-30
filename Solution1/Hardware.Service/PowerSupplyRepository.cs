using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class PowerSupplyRepository : Repository<Data.Entity.PowerSupply>, Data.Interface.IPowerSupplyRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public PowerSupplyRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}