using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Interface.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
         ICaseRepository CaseRepository { get; set; }
         IChipsetRepository ChipsetRepository { get; set; }
         ICoreSeriesRepository CoreSeriesRepository { get; set; }
         ICoreSpeedRepository CoreSpeedRepository { get; set; }
         ICPURepository CPURepository { get; set; }
         ICPUCoolerRepository CPUCoolerRepository { get; set; }
         IEfficiencyRatingRepository EfficiencyRatingRepository { get; set; }
         IFormFactorRepository FormFactorRepository { get; set; }
         IInterfaceRepository InterfaceRepository { get; set; }
         IManufacturerRepository ManufacturerRepository { get; set; }
         IMemorySpeedRepository MemorySpeedRepository { get; set; }
         IMemoryTypeRepository MemoryTypeRepository { get; set; }
         IModuleRepository ModuleRepository { get; set; }
         IMotherboardRepository MotherboardRepository { get; set; }
         INumbersRepository NumbersRepository { get; set; }
         IPowerSupplyRepository PowerSupplyRepository { get; set; }
         IProtocolRepository ProtocolRepository { get; set; }
         IRAMRepository RAMRepository { get; set; }
         ISocketRepository SocketRepository { get; set; }
         IStorageRepository StorageRepository { get; set; }
         IStorageTypeRepository StorageTypeRepository { get; set; }
         IVideoCardRepository VideoCardRepository { get; set; }
         IWirelessAdapterRepository WirelessAdapterRepository { get; set; }
        int Complete();
    }
}
