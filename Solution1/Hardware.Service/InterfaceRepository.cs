using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class InterfaceRepository : Repository<Data.Entity.Interface>, Data.Interface.IInterfaceRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public InterfaceRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}