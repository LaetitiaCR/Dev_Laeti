
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using WebAppliFreelancer.Models;

namespace WebAppliFreelancer.Data
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

       
    }
}
