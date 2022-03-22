using System;

namespace _4
{
    class Person
    {
        private string firstname;
        private string lastname;
        private System.DateTime DateOfBirth;

        public Person(string firstname, string lastname, System.DateTime DateOfBirth)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.DateOfBirth = DateOfBirth;
        }

        public Person()
        {
            this.firstname = "Jon";
            this.lastname = "Moll";
            this.DateOfBirth = new DateTime(2002,08,16);
        }

        private string Firstname 
        {
            get { return this.firstname; }
            set { this.firstname = value; }
        }

        private string Lastname
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }

        private int YearDateOfBirth
        {
            get { return DateOfBirth.Year; }
            set { this.DateOfBirth = new DateTime(value,DateOfBirth.Month, DateOfBirth.Day); }
        }

        public override string ToString()
        {
            return "Имя: " + this.Firstname + "; Фамилия: " + this.Lastname + "; Дата рождения: " + this.DateOfBirth;
        }

        //public override string ToShortString()
        //{
        //    return "Имя: " + this.Firstname + "; Фамилия: " + this.Lastname;
        //}



    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.ToString());
            //person.YearDateOfBirth = 1999;
            //person.ToString();
            //Console.WriteLine(person.YearDateOfBirth);
        }
    }
}
