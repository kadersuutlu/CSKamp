using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //miras - inheritance
    class TuzelMusteri : Musteri//Coorporate Customer
    {
        //public int Id { get; set; }
        //public string MusteriNo { get; set; }
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; } //üzerinde herhangi bir matematiksel işlem yapılmayacağı için string belirtilir.

    }
}
