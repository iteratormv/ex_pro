namespace Exhibition.Model.VisitorDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Description
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Description()
        {
            ExhibitionVisitors = new HashSet<ExhibitionVisitor>();
        }

        public int Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public string Color { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExhibitionVisitor> ExhibitionVisitors { get; set; }
    }
}
