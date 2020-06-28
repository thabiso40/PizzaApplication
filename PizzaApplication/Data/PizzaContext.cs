using Microsoft.EntityFrameworkCore;
using PizzaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Data
{
    public class PizzaContext:DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext>options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

    }
}
