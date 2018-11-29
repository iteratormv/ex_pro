namespace Exhibition.Model
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class ex_mod : DbContext
	{
		public ex_mod()
			: base("name=ex_mod")
		{
		}

		public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
		public virtual DbSet<Cities> Cities { get; set; }
		public virtual DbSet<Companies> Companies { get; set; }
		public virtual DbSet<Descriptions> Descriptions { get; set; }
		public virtual DbSet<ExhibitionVisitors> ExhibitionVisitors { get; set; }
		public virtual DbSet<Exhibits> Exhibits { get; set; }
		public virtual DbSet<Positions> Positions { get; set; }
		public virtual DbSet<Raports> Raports { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Cities>()
				.HasMany(e => e.ExhibitionVisitors)
				.WithRequired(e => e.Cities)
				.HasForeignKey(e => e.CityId);

			modelBuilder.Entity<Companies>()
				.HasMany(e => e.ExhibitionVisitors)
				.WithRequired(e => e.Companies)
				.HasForeignKey(e => e.CompanyId);

			modelBuilder.Entity<Descriptions>()
				.HasMany(e => e.ExhibitionVisitors)
				.WithRequired(e => e.Descriptions)
				.HasForeignKey(e => e.DescriptionId);

			modelBuilder.Entity<Exhibits>()
				.HasMany(e => e.ExhibitionVisitors)
				.WithRequired(e => e.Exhibits)
				.HasForeignKey(e => e.ExhibitId);

			modelBuilder.Entity<Positions>()
				.HasMany(e => e.ExhibitionVisitors)
				.WithRequired(e => e.Positions)
				.HasForeignKey(e => e.PositionId);

			modelBuilder.Entity<Raports>()
				.HasMany(e => e.ExhibitionVisitors)
				.WithRequired(e => e.Raports)
				.HasForeignKey(e => e.RaportId);
		}
	}
}
