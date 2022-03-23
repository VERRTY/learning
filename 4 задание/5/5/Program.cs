using System;
using System.Collections.Generic;

namespace _4._1
{
    public enum TimeFrame { Year, TwoYears, Long };

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
            this.DateOfBirth = new DateTime(2002, 08, 16);
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
            set { this.DateOfBirth = new DateTime(value, DateOfBirth.Month, DateOfBirth.Day); }
        }

        public override string ToString()
        {
            return "Имя: " + this.Firstname + "; Фамилия: " + this.Lastname + "; Дата рождения: " + this.DateOfBirth;
        }

        public virtual string ToShortString()
        {
            return "Имя: " + this.Firstname + "; Фамилия: " + this.Lastname;
        }
    }

    class Paper : Person
    {
        private string publication { get; set; }
        private Person author { get; set; }
        private DateTime pubdata { get; set; }

        public Paper(string Publication, Person Author, DateTime Pubdata)
        {
            this.publication = Publication;
            this.author = Author;
            this.pubdata = Pubdata;
        }
        public Paper()
        {
            this.publication = "Как я учил C#";
            this.author = new Person("sa", "sad", DateTime.Now);
            this.pubdata = System.DateTime.Now;
        }

        public override string ToString()
        {
            return "Название статьи: " + publication + "; Автор: " + author + "; Дата публикации: " + pubdata;
        }

    }

    class ResearchTeam
    {
        private string research_topic;
        private string organization_name;
        private int id;
        private TimeFrame timeframe;
        private List<Paper> listPaper;

        public ResearchTeam(string research_topic, string organization_name, int id, TimeFrame timeframe)
        {
            this.research_topic = research_topic;
            this.organization_name = organization_name;
            this.id = id;
            this.timeframe = timeframe;
            this.listPaper = new List<Paper>() { new Paper("asd", new Person("aas", "asd", DateTime.Now), DateTime.Now) };
        }

        public ResearchTeam()
        {
            this.research_topic = "Что-то";
            this.organization_name = "какя-то организация";
            this.id = 1;
            this.timeframe = TimeFrame.TwoYears;
            this.listPaper = new List<Paper>() { new Paper("asd", new Person("aas", "asd", DateTime.Now), DateTime.Now) };
        }

        public string Research_topic
        {
            get { return research_topic; }
            set { research_topic = value; }
        }

        public string Organization_name
        {
            get { return organization_name; }
            set { organization_name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public TimeFrame Timeframe
        {
            get { return timeframe; }
            set { timeframe = value; }
        }

        public List<string> papers
        {
            get { return papers; }
        }

        public bool this[TimeFrame timeframe]
        {
            get
            {
                if (Timeframe == timeframe)
                {
                    return true;
                }
                else return false;

                //return timeframe switch
                //{
                //    TimeFrame.TwoYears => true,
                //    TimeFrame.Year => true,
                //    TimeFrame.Long => true,
                //    _ => false
                //};

            }
        }

        //public Paper this[int index]
        //{
        //    get => papers[index];
        //}

        public void AddPapers(Paper lpep)
        {
            listPaper.Add(lpep);
        }

        public override string ToString()
        {
            string papers = " Публикации: ";
            foreach (Paper paper in listPaper)
            {
                papers += paper;
            }

            return "Темы исследований: " + Research_topic + "; Организация: " + Organization_name + "; Регистрационный номер: " + Id + "; Продолжительность исследования: " + Timeframe + papers;
        }
        public virtual string ToShortString()
        {
            return "Темы исследований: " + Research_topic + "; Организация: " + Organization_name + "; Регистрационный номер: " + Id + "; Продолжительность исследования: " + Timeframe;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            ResearchTeam team = new ResearchTeam();
            Console.WriteLine(team.ToShortString());
            Console.WriteLine(team[TimeFrame.TwoYears]);
            Person Person1 = new Person("aas", "asd", DateTime.Now);
            Paper paper1 = new Paper("asd", Person1, DateTime.Now);
            team.AddPapers(paper1);
            Console.WriteLine(team.ToString());
            //Console.WriteLine(team.ToString());
        }
    }
}
