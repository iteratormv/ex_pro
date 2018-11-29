namespace Exhibition.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Descriptions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Descriptions()
        {
            ExhibitionVisitors = new HashSet<ExhibitionVisitors>();
        }

        public int Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public string Color { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExhibitionVisitors> ExhibitionVisitors { get; set; }
    }
}
