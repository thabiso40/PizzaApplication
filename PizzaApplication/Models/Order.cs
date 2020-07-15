﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Models
{
    public enum OrderType
    {
        CarryOut,
        Delivery,
        SitIn
    }
    public class Order
    {
        public int ID { get; set; }
       [Required]
        public Customer Customer { get; set; }
        [Required]
        public OrderType OrderType { get; set; }
        public Employee Driver { get; set; }
        public Employee Waiter { get; set; }
        public DateTime? DriverOut { get; set; }
        public DateTime? DriverIn { get; set; }
        [Required]
        IEnumerable<OrderItem> OrderItems { get; set; }



    }
}
