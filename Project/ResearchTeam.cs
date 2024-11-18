using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using TimeFrame;
namespace Project
{
    internal class ResearchTeam
    {
        private string title;
        private string org;
        private int regNumber;
        private Frame time;
        private Paper[] papers;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException("Пустая строка ввода названия.");
                }
                else
                    title = value;
            }
        }
        public string Org
        {
            get
            {
                return org;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException("Пустая строка ввода организации.");
                }
                else
                    org = value;
            }
        }
        public Frame Time
        {
            get
            {
                return time;
            }
            set
            {
                if (value.ToString() == "")
                {
                    throw new ArgumentNullException("Пустая строка ввода продолжительности.");
                }
                else
                    time = value;
            }
        }
        public int RegNumber
        {
            get
            {
                return regNumber;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("Пустая строка ввода названия.");
                }
                else
                    regNumber = value;
            }
        }
        public Paper this[int i]
        {
            get
            {
                if (papers[i] == null)
                {
                    throw new ArgumentNullException("Неправильный индекс.");
                }
                else
                    return papers[i];
            }
            set
            {
                if (value.ToString() == "")
                {
                    throw new ArgumentNullException("Пустой объект.");
                }
                else
                    papers[i] = value;
            }
        }
        public ResearchTeam(string title, string org, int regNumber, int n)
        {
            this.Title = title;
            this.Org = org;
            this.RegNumber = regNumber;
            papers = new Paper[n];
        }
        public ResearchTeam()
        {

        }
        public void AddPapers(params Paper[] paper)
        {
            int new_size = paper.Length + papers.Length;
            Paper[] pap = new Paper[new_size];
            for (int i = 0; i < papers.Length; i++)
            {
                pap[i] = papers[i];
            }
            int ind = 0;
            for (int i = papers.Length; i < pap.Length; i++)
            {
                pap[i] = paper[ind++];
            }
            papers = pap;
        }
        public void Show()
        {
            foreach (Paper p in papers)
            {
                Console.WriteLine(p);
            }
        }
    }
}
