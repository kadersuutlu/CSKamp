using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product
    {
        //snippet-hazır kod
        public int Id { get; set; }
        public int CategoryId { get; set; } //kategorisi
        public string ProductName { get; set; } //adı
        public double UnitPrice { get; set; } //fiyatı
        public int UnitInStock { get; set; } //stok adedi

        //CRUD - Create - Read - Update - Delete
    }
}
