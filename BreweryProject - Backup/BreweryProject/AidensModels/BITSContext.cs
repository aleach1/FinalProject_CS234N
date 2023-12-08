using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreweryEFClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BreweryProject.AidensModels
{
    public partial class BITSContext : DbContext
    {
        public BITSContext() { }

        public BITSContext(DbContextOptions<BITSContext> options) : base(options) { }

        public virtual DbSet<Batch> Batch { get; set; }
        public virtual DbSet<BatchContainer> BatchContainer { get; set; }
        public virtual DbSet<BrewContainer> BrewContainer { get; set; }
        public virtual DbSet<Hop> Hop { get; set; }
        public virtual DbSet<HopType> HopType { get; set; }
        public virtual DbSet<Ingredients> Ingredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigDB.GetMySqlConnectionString();
            if (!optionsBuilder.IsConfigured)
            {
                var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
                optionsBuilder.UseMySql(connectionString, serverVersion);
            }
        }
    }
}
