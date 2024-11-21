using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP.OOP_1_dars
{
    internal class MyClass
    {
        public int First;
        public int Second;
        public void AboutFields()
        {
            Console.WriteLine($"{First} - soni");
            Console.WriteLine($"{Second} - soni");
        }
        public void MaxFields()
        {
            Console.WriteLine($"Ikkita sonning eng kattasi: " + Math.Max(First, Second));
        }
    }
}
