namespace Exhibition.CFModel
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CFExhibitionContext : DbContext
    {
        // Your context has been configured to use a 'CFExhibitionContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Exhibition.CFModel.CFExhibitionContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CFExhibitionContext' 
        // connection string in the application configuration file.
        public CFExhibitionContext()
            : base("name=CFExhibitionContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Visitor> Visitors { get; set; }
        public virtual DbSet<DisplaySetting> DisplaySettings { get; set; }
        public virtual DbSet<DSCollumnSetting> DSCollumnSettings { get; set; }
        //public virtual DbSet<Visitor> Visitors { get; set; }
        //public virtual DbSet<DisplaySetting> DisplaySettings { get; set; }
        //public virtual DbSet<DSCollumnSetting> DSCollumnSettings { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}