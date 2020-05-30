using Hardware.Data.Interface.UnitOfWork;
using Hardware.Service.UnitOfWork;

namespace Hardware.Service
{
    public class VideoCardRepository : Repository<Data.Entity.VideoCard>, Data.Interface.IVideoCardRepository
    {
        private readonly Data.Context.DataContext _dataContext;

        public VideoCardRepository(Data.Context.DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}