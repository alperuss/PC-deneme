using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class ModuleRepository : Repository<Data.Entity.Module>, Data.Interface.IModuleRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public ModuleRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}