using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //miras - inheritance
    class GercekMusteri : Musteri //Individual Customer - Bireysel
    {
        //public int Id { get; set; }
        //public string MusteriNo { get; set; } //üzerinde herhangi bir matematiksel işlem yapılmayacağı için string belirtilir.
        public string Adi { get; set; }
        public string Soyadı { get; set; }
        public string TcNo { get; set; } //üzerinde herhangi bir matematiksel işlem yapılmayacağı için string belirtilir.
    }
}
