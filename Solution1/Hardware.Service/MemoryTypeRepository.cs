using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class MemoryTypeRepository : Repository<Data.Entity.MemoryType>, Data.Interface.IMemoryTypeRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public MemoryTypeRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}