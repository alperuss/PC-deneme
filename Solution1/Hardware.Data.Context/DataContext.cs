
using Microsoft.EntityFrameworkCore;


namespace Hardware.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Entity.Case> Cases { get; set; }
        public DbSet<Entity.CPU> Cpus { get; set; }
        public DbSet<Entity.CPUCooler> CpuCoolers { get; set; }
        public DbSet<Entity.Motherboard> Motherboards { get; set; }
        public DbSet<Entity.PowerSupply> PowerSupplies { get; set; }
        public DbSet<Entity.RAM> Rams { get; set; }
        public DbSet<Entity.Storage> Storages { get; set; }
        public DbSet<Entity.VideoCard> VideoCards { get; set; }
        public DbSet<Entity.WirelessAdapter> WirelessAdapters { get; set; }
    }
}
