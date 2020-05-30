using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class WirelessAdapterRepository : Repository<Data.Entity.WirelessAdapter>, Data.Interface.IWirelessAdapterRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public WirelessAdapterRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}