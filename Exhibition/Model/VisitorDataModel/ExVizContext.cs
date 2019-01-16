namespace Exhibition.Model.VisitorDataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ExVizContext : DbContext
    {
        public ExVizContext()
            : base("name=ExVizContext")
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Description> Descriptions { get; set; }
        public virtual DbSet<ExhibitionVisitor> ExhibitionVisitors { get; set; }
        public virtual DbSet<Exhibit> Exhibits { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Raport> Raports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
