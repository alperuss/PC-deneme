using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class StorageRepository : Repository<Data.Entity.Storage>, Data.Interface.IStorageRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public StorageRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}