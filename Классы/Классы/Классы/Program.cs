using System;

namespace Классы
{
    class Worker : IDisposable
    {
        private string name;
        private string department;
        private int experience;
        private int salary;
        static readonly string company_name = "КРСУ";
        static int workers = 0;
        public Worker()
        {
            workers++;
        }
        public Worker(string name, string department, int experience, int salary)
        {
            this.name = name;
            this.department = department;
            this.salary = salary;
            this.experience = experience;
            workers++;
        }

        public Worker(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
            workers++;
        }
        public void Dispose()
        {
            Console.WriteLine($"{name} has been deleted");
        }

        public static int Workers_counter()
        {
            return workers;
        }

        public static void print_company_name(Worker work)
        {
            Console.WriteLine("Компания: " + company_name);
        }

        public void change_department(string department)
        {
            this.department = department;
        } 

        public void salary_up(int salary)
        {
            this.salary = salary;
        }

        public void Print()
        {
            Console.WriteLine("Имя:" + name);
            Console.WriteLine("Облость: " + department);
            Console.WriteLine("Стаж: " + experience + " Лет");
            Console.WriteLine("Заработная плата: " + salary + " Сом");
            
        }
    }

    class Program{
    
        static void Main(string[] args)
        {
            Worker work1 = new Worker();
            Worker work2 = new Worker("Джамшут",500);
            Worker work3 = new Worker("Равшан","Ош",5,700);

            Console.WriteLine("--------------------------------------------------------");
            Worker.print_company_name(work1);
            Console.WriteLine(Worker.Workers_counter() + "-работяги");
            work1.change_department("Бишкек");
            work1.salary_up(200);
            work1.Print();

            Console.WriteLine("--------------------------------------------------------");
            Worker.print_company_name(work2);
            work2.change_department("Иссык-Куль");
            work2.Print();

            Console.WriteLine("--------------------------------------------------------");
            Worker.print_company_name(work3);
            work3.Print();

            Console.WriteLine();
            work1.Dispose();
            work2.Dispose();
            work3.Dispose();
        }
    }
}


