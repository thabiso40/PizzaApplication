using PizzaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Data
{
    public static class DBInitializer
    {
        public static void Initialize(PizzaContext context)
        {
            //context.Database.EnsureCreated();
            if (context.Employees.Any())
            {
                return;
            }
            Employee[] employees = new Employee[]
            {
                new Employee{FirstName="jesse", LastName="prescot",PhoneNumber="012-312-5185",Role=Roles.Manager,salary=450000},
                 new Employee{FirstName="Thabo", LastName="jackson",PhoneNumber="012-312-5034",Role=Roles.AssistentManeger,salary=350000},
                  new Employee{FirstName="karl", LastName="watson",PhoneNumber="012-312-5888",Role=Roles.chef,salary=300000}
            };
                context.AddRange(employees);
                context.SaveChanges();
            
        }
    }
}