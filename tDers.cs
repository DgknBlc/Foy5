namespace Foy5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tDers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tDers()
        {
            tOgrenciDers = new HashSet<tOgrenciDers>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dersID { get; set; }

        [StringLength(25)]
        public string dersAD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tOgrenciDers> tOgrenciDers { get; set; }
    }
}
