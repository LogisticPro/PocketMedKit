﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using Microsoft.Data.SqlClient;

namespace DAL.Db_Models
{
    public class PocketMedKitAppDbContext : DbContext
    {
        private IConfiguration _configuration;

        public DbSet<User> Users { get; set; }
        public DbSet<Pocket> Pockets { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<PocketMedicine> PocketMedicines { get; set; }

        public PocketMedKitAppDbContext()
        {
            Database.EnsureCreated();
        }

        public PocketMedKitAppDbContext(DbContextOptions<PocketMedKitAppDbContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string? connString = _configuration.GetConnectionString("ConnectionString1");
            optionsBuilder.UseSqlServer(connString);
        }
    }
}