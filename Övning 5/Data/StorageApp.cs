using Microsoft.EntityFrameworkCore;
using Övning_5.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5.Data
{
    public class StorageApp : DbContext
    {
        public DbSet<vehiclesInGarage> Vehicles => Set<vehiclesInGarage>();
        public DbSet<Airplane> Airplanes => Set<Airplane>();
        public DbSet<garageBuildings> Garages => Set<garageBuildings>();
        public DbSet<Boat> Boats => Set<Boat>();
        public DbSet<Bus> Busses => Set<Bus>();
        public DbSet<Car> Cars => Set<Car>();
        public DbSet<Motorcycle> Motorcycles => Set<Motorcycle>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDB");
        }
    }

}
