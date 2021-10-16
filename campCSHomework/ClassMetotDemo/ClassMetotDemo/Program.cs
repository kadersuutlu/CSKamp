using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriId = 1;
            musteri1.musteriAdı = "Kader";
            musteri1.musteriSoyadı = "Sutlu";
            musteri1.musteriNo = "192511031";

            Musteri musteri2 = new Musteri();
            musteri2.musteriId = 2;
            musteri2.musteriAdı = "Elanur";
            musteri2.musteriSoyadı = "Kaşcıoğlu";
            musteri2.musteriNo = "192511015";

            Musteri musteri3 = new Musteri();
            musteri3.musteriId = 3;
            musteri3.musteriAdı = "Hatice Nur";
            musteri3.musteriSoyadı = "Kaya";
            musteri3.musteriNo = "192511037";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.List(musteriler);
        }
    }
}
