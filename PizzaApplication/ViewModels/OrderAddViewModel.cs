using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.ViewModels
{
    public class OrderAddViewModel
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public OrderType OrderType { get; set; }
        public IEnumerable<OrderItem>OrderItems{get;set;}

        public IEnumerable<SelectListItem> CustomerList { get; set; }
      
    }
}
