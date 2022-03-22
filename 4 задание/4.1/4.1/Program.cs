using System;

namespace _4._1
{
    public enum TimeFrame { Year, TwoYears, Long };

    class Paper
    {
        private string publication { get; set; }
        private string author { get; set; }
        private DateTime pubdata { get; set; }

        public Paper(string Publication, string Author, DateTime Pubdata)
        {
            this.publication = Publication;
            this.author = Author;
            this.pubdata = Pubdata;
        }
        public Paper()
        {
            this.publication = "Как я учил C#";
            this.author = "Кто-то";
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
        private Paper[] papers;

        public ResearchTeam(string research_topic, string organization_name, int id, TimeFrame timeframe)
        {
            this.research_topic = research_topic;
            this.organization_name = organization_name;
            this.id = id;
            this.timeframe = timeframe;
        }

        public ResearchTeam()
        {
            this.research_topic = "Что-то";
            this.organization_name = "какя-то организация";
            this.id = 1;
            this.timeframe = TimeFrame.TwoYears;
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

        public Paper[] Paper
        {
            get { return papers; }
            set { papers = value; }
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

        //public void AddPapers(params Paper[])
        //{
        //    this.papers = new Paper[papers.Length];
        //}

        public override string ToString()
        {
            return "Темы исследований: " + Research_topic + "; Организация: " + Organization_name + "; Регистрационный номер: " + Id + "; Продолжительность исследования: " + Timeframe + "; Публикации: " + Paper;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            ResearchTeam team = new ResearchTeam();
            //Console.WriteLine(team.ToShortString());
            Console.WriteLine(team[TimeFrame.TwoYears]);
            Console.WriteLine(team.ToString());
        }
    }
}
