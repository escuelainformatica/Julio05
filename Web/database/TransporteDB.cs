using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Web.database
{
    public partial class TransporteDB : DbContext
    {
        public TransporteDB()
            : base("name=TransporteDB")
        {
        }

        public virtual DbSet<TipoVehiculo> TipoVehiculo { get; set; }
        public virtual DbSet<Vehiculo> Vehiculo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoVehiculo>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.Patente)
                .IsUnicode(false);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.Conductor)
                .IsUnicode(false);
        }
    }
}
