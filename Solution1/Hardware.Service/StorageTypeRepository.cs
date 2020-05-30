using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class StorageTypeRepository : Repository<Data.Entity.StorageType>, Data.Interface.IStorageTypeRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public StorageTypeRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}