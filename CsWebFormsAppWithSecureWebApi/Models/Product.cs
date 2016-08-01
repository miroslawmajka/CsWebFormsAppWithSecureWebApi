﻿using System;

namespace CsWebFormsAppWithSecureWebApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}