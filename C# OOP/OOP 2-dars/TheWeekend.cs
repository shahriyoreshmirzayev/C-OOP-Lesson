using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP.OOP_2_dars
{
    internal class TheWeekend
    {
        string[] days = new string[] { "Dushanba", "Seshanba", "Chorshanba", "Payshanba", "Juma", "Shanba", "Yakshanba" };
        private int _dayOfWeek;
        private string _dayOfWeekText;
        public int DayOfWeek
        {
            get
            {
                return _dayOfWeek;
            }
            set
            {
                if (value > 0 && value < 8)
                {
                    _dayOfWeek = value;
                    _dayOfWeekText = days[_dayOfWeek - 1];
                }
                else
                {
                    Console.WriteLine("Qiymat noto'g'ri !!!");
                }
            }
        }
        public string DayOfWeekText
        {
            get
            {
                return _dayOfWeekText;
            }
            set
            {
                _dayOfWeekText = value;

            }
        }
    }
}
