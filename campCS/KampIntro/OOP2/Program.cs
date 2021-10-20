using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Engin";
            //musteri1.Soyadı = "Demiroğ";
            //musteri1.Id = 1;
            //musteri1.TcNo = "12344567890";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?";

            //Gerçek Müşteri - Tüzel Müşteri birbirinin yerine asla kullanılamaz.

            //SOLID - L

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadı = "Demiroğ";
            musteri1.TcNo = "12345678900";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            Musteri musteri3 = new GercekMusteri(); //Bellekteki referans no
            Musteri musteri4 = new TuzelMusteri(); //Bellekteki referans no
            //Musteri no hem gerçek müşterinin hem de tüzel müşterinin referans numarasını tutabilir.

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}
