using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //base class //temel sınıf : referans tutucu
    class Musteri //Ebeveyn
    {
        //class'lar özellik + operasyon tutar.

        public int Id { get; set; }
        public string MusteriNo { get; set; } //üzerinde herhangi bir matematiksel işlem yapılmayacağı için string belirtilir.
        //public string Adi { get; set; }
        //public string Soyadı { get; set; }
        //public string SirketAdi { get; set; }
        //public string TcNo { get; set; } //üzerinde herhangi bir matematiksel işlem yapılmayacağı için string belirtilir.
        //public string VergiNo { get; set; } //üzerinde herhangi bir matematiksel işlem yapılmayacağı için string belirtilir.

        //Eğer bir nesnede o nesneyi kullanmak zorunda değilsek o nesnede soyutlama hatası vardır. SirketAdi gibi

    }
}
