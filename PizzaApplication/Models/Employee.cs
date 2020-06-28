using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Models
{
    public enum Roles
    {
        Driver,
        chef,
        cashier,
        AssistentManeger,
        Manager

    }
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Roles Role { get; set; }
        public string PhoneNumber { get; set; }
        public decimal salary { get; set; }
    }
}
