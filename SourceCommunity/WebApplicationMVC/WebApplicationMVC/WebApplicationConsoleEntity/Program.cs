using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationConsoleEntity.Models;

namespace WebApplicationConsoleEntity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            using (FreelancerDbContext context = new FreelancerDbContext())
            {

                Customer customer = new Customer()
                {
                    CustomerName = "Jean",
                    CustomerEmail = "JeanFleurit@free.fr"
                };


                context.Customers.Add(customer);

                context.SaveChanges();

                Console.ReadLine();

                IEnumerable<Customer> customers = context.Customers.ToList();

                foreach (Customer u in customers)
                {
                    Console.WriteLine(u.CustomerId + ": " + u.CustomerName);
                }

            }


            Console.ReadLine();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
        {
                    webBuilder.UseStartup<Startup>();
        });
    }
}
