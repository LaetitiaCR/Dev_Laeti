using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using WebApplicationConsoleEntity.Models;

namespace WebApplicationConsoleEntity
{
    public class FreelancerDbContext : DbContext
    {
        public FreelancerDbContext()
        {
        }

        public FreelancerDbContext(DbContextOptions<FreelancerDbContext> options): base(options)
        { }

        //      <TypeDuModele>  table
        public DbSet<Customer> Customers { get; set; }
        
        public DbSet<Customercat> Customercats { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Quote> Quotes { get; set; }


        /*
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // ajout d'un index unique
            // builder.Entity<Engine>().HasIndex(item => item.Puissance).IsUnique();
        }



        public FreelancerContext(DbContextOptions<FreelancerContext> options) : base(options)
        {

        }

        */

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("appsettings.json");
            var configuration = configurationBuilder.Build();
            //var connectionString = Configuration.GetSection("ConnectionStrings")["DbFreelancerConnectionString"];
           
            var connectionString = configuration["Data:DefaultConnection:ConnectionString"];
            //Configuration.GetConnectionString("DefaultConnection");
            //UseSqlServer("name=ConnectionStrings:DefaultConnection")
            // Create an instance of a SQL Server DBContext
            var options = new DbContextOptionsBuilder();
            options.UseSqlServer(connectionString);
            //var context = new MyDbContext(options.Options);


            //optionsBuilder.UseSqlServer(@"Server=(DESKTOP- CMNIL4R)\mssqllocaldb; Database = DbUsersTests; Trusted_Connection = True; MultipleActiveResultSets = true");
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DbFreelancerTests;Trusted_Connection=True;MultipleActiveResultSets=true");

        }      
          


        /*

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(System.Configuration.ConfigurationManager.ConnectionStrings["DbFreelancerConnectionString"].ConnectionString);
        }
        */

        /*
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        */

    }
}
