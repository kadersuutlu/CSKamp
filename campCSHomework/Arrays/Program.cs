using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Engin";
            string student2 = "Derin";
            string student3 = "Salih";

            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            //array elemanları array tipinde olmalıdır.
            //Koleksiyonlar arraylarin iyileştirilmiş,kolaylaştırılmış halidir.

            string[] students1 = new[] { "Engin","Salih","Derin"};
            string[] students2 =  { "Engin","Salih","Derin"};
            string[] students3 = new string[3] { "Engin", "Salih", "Derin" }; 

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
