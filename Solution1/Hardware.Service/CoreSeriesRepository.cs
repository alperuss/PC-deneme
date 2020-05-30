using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class CoreSeriesRepository : Repository<Data.Entity.CoreSeries>, Data.Interface.ICoreSeriesRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public CoreSeriesRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}