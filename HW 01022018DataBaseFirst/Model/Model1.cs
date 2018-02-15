namespace HW_01022018DataBaseFirst.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<TablesManufacturer> TablesManufacturer { get; set; }
        public virtual DbSet<TablesStopReason> TablesStopReason { get; set; }
        public virtual DbSet<TrackMeter> TrackMeter { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
