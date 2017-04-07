namespace HotelDBWebserviceDemo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HotelViewContext : DbContext
    {
        public HotelViewContext()
            : base("name=HotelViewContext")
        {
        }

        public virtual DbSet<HotelDemoView> HotelDemoView { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelDemoView>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<HotelDemoView>()
                .Property(e => e.Types)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
