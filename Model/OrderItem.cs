﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderItem
    {
        public int Id { get; set; } 
        public int OrderId { get; set; }
        public MenuItem MenuItem { get; set; }
        public int Amount { get; set; }
        public string Comment { get; set; }
        public bool Ready { get; set; }
        public float TotalPrice { get; set; }

        public OrderItem(int id, int orderId, MenuItem menuItem, int amount, string comment, bool ready)
        {
            Id = id;
            OrderId = orderId;
            MenuItem = menuItem;           
            Ready = ready;
            Comment = comment;
            Amount = amount;
        }

        public OrderItem(int id, int orderId, int amount, MenuItem menuItem, string comment, bool ready)
        {
            Id = id;
            OrderId = orderId;
            MenuItem = menuItem;
            Comment = comment;
            Ready = ready;
            Amount = amount;
        }

        public OrderItem(int id, MenuItem menuItem, int amount, float totalPrice)
        {
            Id = id;
            MenuItem = menuItem;
            Amount = amount;
            TotalPrice = totalPrice;
        }
        public OrderItem(int orderId, MenuItem menuItem, int amount, string comment)
        {
            OrderId = orderId;
            MenuItem = menuItem;
            Comment = comment;
            Ready = false;
            Amount = amount;
        }

        public OrderItem(MenuItem menuItem, int amount)
        {

        }

        public OrderItem()
        {

        }
    }
}
