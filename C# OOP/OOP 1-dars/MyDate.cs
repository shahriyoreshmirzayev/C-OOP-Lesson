using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP.OOP_1_dars
{
    internal class MyDate
    {
        public int year;
        public int month;
        public int day;

        public void PrintDate()
        {
            Console.WriteLine($"{day:D2}.{month:D2}.{year}");
        }
    }
}
