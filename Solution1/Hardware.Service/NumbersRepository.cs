using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class NumbersRepository : Repository<Data.Entity.Numbers>, Data.Interface.INumbersRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public NumbersRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}