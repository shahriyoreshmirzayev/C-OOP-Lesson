using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP.OOP_2_dars
{
    internal class Time1
    {
        private int _hours;
        private int _minutes;
        private int _seconds;
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if(value > 0 && value < 25)
                {
                    _hours = value;
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    _minutes = value;
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    _seconds = value;
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
    }
}
