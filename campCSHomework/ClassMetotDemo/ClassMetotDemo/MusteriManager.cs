using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler! Müşteri eklendi: " + musteri.musteriAdı);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Tebrikler! Müşteri silindi: " + musteri.musteriAdı);
        }

        public void List(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.musteriAdı);
            }
        }

    }
}
