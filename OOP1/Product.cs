using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snipped = hazir kodlar
    class Product
    {
        public int Id { get; set; } //primary key
        public int CategoryId { get; set; } //foreign key, boyle yazariz genelde
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //CRUD = Creat Read Update Delete
    }
}
