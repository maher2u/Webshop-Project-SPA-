using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WebshopProject.Models
{
    public class ModelClass
    {
        public string Search { get; set; }
    }

    public class Product
    {
        public int ID { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public string category { get; set; }
        public decimal price { get; set; }

    }
    public class Order
    {
        public int ID { get; set; }
        public int cartID { get; set; }
        public int productID { get; set; }
        public int amount { get; set; }

        public virtual Product product { get; set; }
        public virtual Cart cart { get; set; }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }

        public virtual List<Cart> carts { get; set; }
    }
    public class Cart
    {
        public int ID { get; set; }
        public string status { get; set; }
        public int customerID { get; set; }

        public virtual Customer customer { get; set; }
        public virtual List<Order> orders { get; set; }
    }

    public class WebshopContext : DbContext
    {
        public WebshopContext() : base("DefaultConnection")
        {

        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}