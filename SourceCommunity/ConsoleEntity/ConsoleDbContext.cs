using ConsoleEntity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEntity
{
    class ConsoleDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        // pour les APP ASP.NET Core
        /*public ConsoleDbContext(DbContextOptions<ConsoleDbContext> options) : base(options)
        {

        }*/

        // en mode console, on passe la config du SGBD dans OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //"DevConnection": "Server=DESKTOP- CMNIL4R;Database=DuUserTests;User Id=DB_xxxxx_user;Password=xxsomepwdxx;Integrated Security=false;MultipleActiveResultSets=true;"
            //Server = myServerAddress; Database = myDataBase
           
            //optionsBuilder.UseSqlServer("DESKTOP- CMNIL4R\\mssqllocaldb; Database = DbConsole; Trusted_Connection = True; MultipleActiveResultSets = true");
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DbConsole;Trusted_Connection=True;MultipleActiveResultSets=true");
            //connectionString = "Data Source=DESKTOP-3FGO1M6\SQLEXPRESS;Initial Catalog=PapyrusAndrea;Integrated Security=True"
        }

    }
}
