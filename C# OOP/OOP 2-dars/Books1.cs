using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP.OOP_2_dars
{
    internal class Books1
    {
        public string author { get; set; }
        public double price { get; set; }
        public double salary { get; set; }
        public string name { get; set; }
        public int paper_count { get; set; }
    }
    class EBook : Books1
    {
        public string site_name { get; set; }
        public int site_size_mb { get; set; }
        public void GetEbookPrint()
        {
            Console.WriteLine("EBook da sarlavha chop etilmoqda !!");
        }
    }
    class PaperBooks : Books1
    {
        public string size_paper { get; set; }
        public int uber_days { get; set; }
    }
}
