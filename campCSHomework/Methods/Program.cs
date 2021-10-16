using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //var result=Add2(20);
            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(out number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            //Console.WriteLine(result);
            //Console.ReadLine();
            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,8));
            Console.WriteLine(Add4(1,3,4,8,9,7));
        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2=30) //default değer her zaman metodun sonunda olması gerekir.
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(out int number1,int number2)
            //ref keywordünü kullandığımızda number1'in değeri metodda verilen değerdir, yani değeri 30 olarak kalır.
            //out da ref gibi kullanılır. ref de değer atamadan gönderemezsin ama out da böyle bir zorunluluk yok.
        {
            number1 = 30;//out da bu ifade zorunludur.
            return number1 + number2;
        }

        //overloid:aşırı yüklenme
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        }

        //params ile methoda aynı tipte istediğimiz sayıda parametre gönderebiliriz. params methoddaki parametrelerin sonuncusu olmak zorunda
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
