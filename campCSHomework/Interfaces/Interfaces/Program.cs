using System;

namespace Interfaces
{
    class Program
    {

        //interface ler new lenemez.
        static void Main(string[] args)
        {
           // IPersonManager customerManager = new CustomerManager();

            // IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());

            Console.ReadLine();
        }
    }

    //class PersonManager
    //{
    //    //implemented operation:tamamlanmış operasyon
    //    public void Add()  //her yerde ortak
    //    {
    //        Console.WriteLine("Eklendi");
    //    }
    //}

    //class CustomerManager:PersonManager
    //{

    //}

    interface IPersonManager
    {
        //unimplemented operation:tamamlanmamış operasyon
        void Add();
        void Update();
    }

    //inherits- class --------------------implements -interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi.");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi.");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer eklendi.");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            
            personManager.Add();
        }
    }
}
