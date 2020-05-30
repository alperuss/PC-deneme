using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class ProtocolRepository : Repository<Data.Entity.Protocol>, Data.Interface.IProtocolRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public ProtocolRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}