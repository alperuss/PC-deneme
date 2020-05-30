using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class ManufacturerRepository : Repository<Data.Entity.Manufacturer>, Data.Interface.IManufacturerRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public ManufacturerRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}