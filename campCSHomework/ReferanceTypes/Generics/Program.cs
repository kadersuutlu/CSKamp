
using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Genericlerde hangi tipte verilirse içerisine verilecek parametrelerde o tipte olmalıdır.
            List<string> sehirler = new List<string>();
            sehirler.Add("İstanbul");//Add metot
            sehirler.Add("İstanbul");//Add metot
            sehirler.Add("İstanbul");//Add metot
            sehirler.Add("İstanbul");//Add metot
            sehirler.Add("İstanbul");//Add metot
            sehirler.Add("İstanbul");//Add metot
            Console.WriteLine(sehirler.Count);//count propert yani readonly
            

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
            
        }
    }

    class MyList<T>//T:type:tip //Generic Class
    {
        T[] _array;
        T[] _tempArray;     //_array'in kopyasını tutar.
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(string item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];//Array'ı newlemek gerekir eleman her eklediğinde sayıyı 1 arttırmalıdır.
            //newlendiğinde boş bir dizi oluşur. _tempArray'in elemanlarını tekrardan _array'e atamak gerekir.
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
        }
        private int _count;

        public int Count 
        {
            get { return _array.Length; }
        }
    }
}
