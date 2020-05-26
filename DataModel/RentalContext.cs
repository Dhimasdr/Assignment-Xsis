namespace DataModel
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RentalContext : DbContext
    {
        // Your context has been configured to use a 'RentalContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DataModel.RentalContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'RentalContext' 
        // connection string in the application configuration file.
        public RentalContext()
            : base("name=RentalContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<DataRent> DataRents { get; set; }
        public virtual DbSet<Transport_List> Transport_Lists { get; set; }
        public virtual DbSet<data_user> data_users { get; set; }

       // public System.Data.Entity.DbSet<WebApplication1.Models.Rent_list> Rent_list { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}