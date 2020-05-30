using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class ChipsetRepository : Repository<Data.Entity.Chipset>, Data.Interface.IChipsetRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public ChipsetRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}