namespace Web.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vehiculo")]
    public partial class Vehiculo
    {
        [Key]
        [StringLength(10)]
        public string Patente { get; set; }

        public int? IdTipoVehiculo { get; set; }

        [StringLength(50)]
        public string Conductor { get; set; }

        public int? Ejes { get; set; }

        public virtual TipoVehiculo TipoVehiculo { get; set; }
    }
}
