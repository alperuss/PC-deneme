using Hardware.Data.Context;
using Hardware.Data.Interface;
using Hardware.Data.Interface.UnitOfWork;

namespace Hardware.Service.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICaseRepository CaseRepository { get; set; }
        public IChipsetRepository ChipsetRepository { get; set; }  
        public ICoreSeriesRepository CoreSeriesRepository { get; set; }  
        public ICoreSpeedRepository CoreSpeedRepository { get; set; } 
        public ICPURepository CPURepository{ get; set; } 
        public ICPUCoolerRepository CPUCoolerRepository{ get; set; } 
        public IEfficiencyRatingRepository EfficiencyRatingRepository{ get; set; } 
        public IFormFactorRepository FormFactorRepository{ get; set; } 
        public IInterfaceRepository InterfaceRepository{ get; set; } 
        public IManufacturerRepository ManufacturerRepository{ get; set; } 
        public IMemorySpeedRepository MemorySpeedRepository{ get; set; } 
        public IMemoryTypeRepository MemoryTypeRepository{ get; set; } 
        public IModuleRepository ModuleRepository{ get; set; } 
        public IMotherboardRepository MotherboardRepository{ get; set; } 
        public INumbersRepository NumbersRepository{ get; set; } 
        public IPowerSupplyRepository PowerSupplyRepository{ get; set; } 
        public IProtocolRepository ProtocolRepository{ get; set; } 
        public IRAMRepository RAMRepository{ get; set; } 
        public ISocketRepository SocketRepository{ get; set; } 
        public IStorageRepository StorageRepository{ get; set; } 
        public IStorageTypeRepository StorageTypeRepository{ get; set; } 
        public IVideoCardRepository VideoCardRepository{ get; set; } 
        public IWirelessAdapterRepository WirelessAdapterRepository{ get; set; } 
        
        private readonly DataContext _dataContext;
        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
            CaseRepository = new CaseRepository(_dataContext);
            ChipsetRepository = new ChipsetRepository(_dataContext);
            CoreSeriesRepository = new CoreSeriesRepository(_dataContext);
            CoreSpeedRepository = new CoreSpeedRepository(_dataContext);
            CPURepository = new CPURepository(_dataContext);
            CPUCoolerRepository = new CPUCoolerRepository(_dataContext);
            EfficiencyRatingRepository = new EfficiencyRatingRepository(_dataContext);
            FormFactorRepository = new FormFactorRepository(_dataContext);
            InterfaceRepository = new InterfaceRepository(_dataContext);
            ManufacturerRepository = new ManufacturerRepository(_dataContext);
            MemorySpeedRepository = new MemorySpeedRepository(_dataContext);
            MemoryTypeRepository = new MemoryTypeRepository(_dataContext);
            ModuleRepository = new ModuleRepository(_dataContext);
            MotherboardRepository = new MotherboardRepository(_dataContext);
            NumbersRepository = new NumbersRepository(_dataContext);
            PowerSupplyRepository = new PowerSupplyRepository(_dataContext);
            ProtocolRepository = new ProtocolRepository(_dataContext);
            RAMRepository = new RAMRepository(_dataContext);
            SocketRepository = new SocketRepository(_dataContext);
            StorageRepository = new StorageRepository(_dataContext);
            StorageTypeRepository = new StorageTypeRepository(_dataContext);
            VideoCardRepository = new VideoCardRepository(_dataContext);
            WirelessAdapterRepository = new WirelessAdapterRepository(_dataContext);
        }

        public int Complete()
        {
            return _dataContext.SaveChanges();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}