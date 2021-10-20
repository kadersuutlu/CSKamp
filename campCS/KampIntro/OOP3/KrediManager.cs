using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    /*class*/interface IKrediManager //ebeveyn - base // I : Interface : Genellikle operasyonel metotlarda kullanılır.
     //referans tutması için ve uygulanması zorunlu halde istenen operasyoları ttutması için oluşturulur.
     //İnterface'ler birbirlerinin alternatifleri olan ama kod içerikleri farklı olan durumlar için kullanırız.
     //İnterface'ler SOLID'in O kuralına uyar.
     //Yani projeye yeni bir class eklendiğinde projenin diğer kodlarında değişiklik yapılmaya ihtiyaç olmaz.
     
    {
        /*public*/
        void Hesapla();
        //{

        //}
        void BisyeYap();
    }
}
