
using Microsoft.EntityFrameworkCore;
using Proje_OOP.Entity;

namespace Proje_OOP.Entity
{
    public class Customer
    {
        
        //int a ; -> Bu bir değişken
        //public int Myvalue { get; set; } -> Bu bir property'dir. Property'e büyük harfle başlanır.
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCity  { get; set; }
        
    }
}
