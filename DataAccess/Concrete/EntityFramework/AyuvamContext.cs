using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class AyuvamContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-2BG1A2U; Database=AYuvam;Trusted_Connection=true");
        }
        public DbSet<ConnectedDevice> ConnectedDevices { get; set; }
        public DbSet<DeviceLog> DeviceLogs { get; set; }
        public DbSet<HomeRoom> HomeRooms { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<MainDevice> MainDevices { get; set; }
        public DbSet<NormalUser> NormalUsers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomSensor> RoomSensors { get; set; }
        public DbSet<SensorDevice> SensorDevices { get; set; }
        public DbSet<UserHome> UserHomes { get; set; }
        public DbSet<UserSensorDevice> UserSensorDevices { get; set; }

    }
}
