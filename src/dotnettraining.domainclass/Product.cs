﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetTraining.domainClass
{
    public class Product
    {

        public int Id { get; set; }
        public string ProductType { get; set; }
        public string ProductName { get; set; }
        public int CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public bool Validate()
        {
            return true;
        }
    }
}
