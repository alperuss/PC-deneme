using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class MotherboardRepository : Repository<Data.Entity.Motherboard>, Data.Interface.IMotherboardRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public MotherboardRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}