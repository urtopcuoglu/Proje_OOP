using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proje_OOP.Entity;
namespace Proje_OOP.Entity
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Productname { get; set; }
        public decimal ProductPrice { get; set; }
        public int Stock { get; set; }

     
    }
    
}
