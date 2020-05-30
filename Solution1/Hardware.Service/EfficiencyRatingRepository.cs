using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class EfficiencyRatingRepository : Repository<Data.Entity.EfficiencyRating>, Data.Interface.IEfficiencyRatingRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public EfficiencyRatingRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}