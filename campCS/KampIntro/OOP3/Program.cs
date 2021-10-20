using System;
using System.Collections.Generic;

namespace OOP3
{
    //loglama: kim ne zaman hangi opersayonu çağırdı.//bir dosya da ya da veritabanında tutulabilir.sms-mail gönderme gibi
    class Program
    {
        static void Main(string[] args)
        {
            //İnterface'lerde o interface'i iplemente eden class'ın referans numarasını tutabilir.
            IKrediManager ihtiyackrediManager = new IhtiyacKrediManager();
            //ihtiyackrediManager.Hesapla();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(parametre);
            //hangi kredi verilirse onun hesapla metodu çalışır.
            basvuruManager.BasvuruYap(new EsnafKrediManager(),
                new List<ILoggerService> { new DatabaseLoggerService(),new SmsLoggerService()});
            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(konutKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyackrediManager,tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
