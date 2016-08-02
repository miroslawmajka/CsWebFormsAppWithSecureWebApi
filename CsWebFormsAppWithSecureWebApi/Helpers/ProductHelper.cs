using CsWebFormsAppWithSecureWebApi.Models;
using System;
using System.Collections.Generic;

namespace CsWebFormsAppWithSecureWebApi.Helpers
{
    public class ProductHelper
    {
        public static List<Product> GetAllPRoducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Tomato Soup",
                    Category = "Groceries",
                    Price = 1,
                    UpdateTime = DateTime.Now
                },
                new Product
                {
                    Id = 2,
                    Name = "Yo-yo",
                    Category = "Toys",
                    Price = 3.7,
                    UpdateTime = DateTime.Now
                },
                new Product
                {
                    Id = 3,
                    Name = "Hammer",
                    Category = "Hardware",
                    Price = 16.99,
                    UpdateTime = DateTime.Now
                }
            };
        }
    }
}