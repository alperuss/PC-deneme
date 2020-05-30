using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class FormFactorRepository : Repository<Data.Entity.FormFactor>, Data.Interface.IFormFactorRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public FormFactorRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}