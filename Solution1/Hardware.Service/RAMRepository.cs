using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class RAMRepository : Repository<Data.Entity.RAM>, Data.Interface.IRAMRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public RAMRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}