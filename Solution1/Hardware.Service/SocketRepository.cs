using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class SocketRepository : Repository<Data.Entity.Socket>, Data.Interface.ISocketRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public SocketRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}