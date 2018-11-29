namespace Exhibition.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ExhibitionVisitors
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

        public string Payment_Status { get; set; }

        public string Payment_Status_Comment { get; set; }

        public string Source_Code { get; set; }

        public string Event_Code { get; set; }

        public string Event_Name { get; set; }

        public DateTime? DateCreated { get; set; }

        public int CityId { get; set; }

        public int CompanyId { get; set; }

        public int PositionId { get; set; }

        public int DescriptionId { get; set; }

        public int ExhibitId { get; set; }

        public int RaportId { get; set; }

        public virtual Cities Cities { get; set; }

        public virtual Companies Companies { get; set; }

        public virtual Descriptions Descriptions { get; set; }

        public virtual Exhibits Exhibits { get; set; }

        public virtual Positions Positions { get; set; }

        public virtual Raports Raports { get; set; }
    }
}
