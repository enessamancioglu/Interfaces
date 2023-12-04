namespace Interfaces
{
    internal class Program
    {
        //interface new'lenemez!
        static void Main(string[] args)
        {
           
            ////interfaceler onu implemente eden classin referansini tutabilirler
            //IPersonManager customer1 = new CustomerManager();
            //customer1.Add();
            //customer1.Update();

            //IPersonManager employee1 = new EmployeeManager();
            //employee1.Add();
            //employee1.Update();
           
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());

        }
    }
    interface IPersonManager
    {
        //unimplemented operation
        void Add();

        void Update();
    }

    //inherit-class ------------implemet-interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Musteri Ekleme Kodlari
            Console.WriteLine("Musteri Eklendi!");
        }

        public void Update()
        {
            Console.WriteLine("Musteri Guncellendi!");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //Calisan Ekleme Kodlari
            Console.WriteLine("Calisan Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Caslisan Guncellendi!");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajer Eklendi!");
        }

        public void Update()
        {
            Console.WriteLine("Stajer Guncelleni!");
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