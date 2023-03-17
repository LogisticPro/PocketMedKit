using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Db_Models
{
    public class PocketMedKitAppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Pocket> Pockets { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<PocketMedicine> PocketMedicines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(/*строка подключения*/);
        }
    }
}