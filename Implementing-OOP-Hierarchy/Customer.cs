﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class Customer
    {
        private List<Order> _orderHistory = new List<Order>();

        public string Name { get; set; }
        public string Email { get; set; }


        public IReadOnlyCollection<Order> OrderHistory => this._orderHistory.AsReadOnly();

        public Customer(string name, string email)
        {
            this.Email = email;
            this.Name = name;
        }


        public void AddOrder(Order order)
        {
            this._orderHistory.Add(order);
        }
    }
}
