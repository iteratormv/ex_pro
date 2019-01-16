namespace Exhibition.Model.VisitorDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ExhibitionVisitor
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string BarCode { get; set; }

        public string Status { get; set; }

        public string WorkPhone { get; set; }

        public string Pathronim { get; set; }

        public int CityId { get; set; }

        public int CompanyId { get; set; }

        public int PositionId { get; set; }

        public int DescriptionId { get; set; }

        public int ExhibitId { get; set; }

        public int RaportId { get; set; }

        public DateTime? DateCreated { get; set; }

        public virtual City City { get; set; }

        public virtual Company Company { get; set; }

        public virtual Description Description { get; set; }

        public virtual Exhibit Exhibit { get; set; }

        public virtual Position Position { get; set; }

        public virtual Raport Raport { get; set; }
    }
}
