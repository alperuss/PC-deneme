using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class MemorySpeedRepository : Repository<Data.Entity.MemorySpeed>, Data.Interface.IMemorySpeedRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public MemorySpeedRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}