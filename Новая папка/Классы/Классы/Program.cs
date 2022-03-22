using System;

namespace Классы
{
    class Worker
    {
        private string name;
        private int id;
        private string department;
        private int experience;
        public int salary;
        public Worker(string name, string department, int experience, int salary)
        {
            this.id = 500;
            this.name = name;
            this.department = department;
            this.salary = salary;
            this.experience = experience;
        }

        public Worker()
        {

        }

        public void change_department(string department)
        {
            this.department = department;
        } 

        public void salary_up(int salary)
        {
            this.salary = salary;
        }

        public static void Print(Worker worker)
        {
            Console.WriteLine($"{worker.id} ");
            Console.WriteLine(worker.name);
        }
    }

    class Program{
    
        static void Main(string[] args)
        {
            Worker worker = new Worker("qe","qw");
            Worker.Print(worker);
        }
    }
}


