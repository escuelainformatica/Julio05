namespace Web.database
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    [Table("TipoVehiculo")]
    public partial class TipoVehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoVehiculo()
        {
            Vehiculo = new HashSet<Vehiculo>();
        }

        [Key]
        public int IdTipoVehiculo { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [XmlIgnore] // ASMX, WCF
        [JsonIgnore] // WCF Ajax
        [IgnoreDataMember] // WebApi
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
    }
}
