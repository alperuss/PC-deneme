using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class CoreSpeedRepository : Repository<Data.Entity.CoreSpeed>, Data.Interface.ICoreSpeedRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public CoreSpeedRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}