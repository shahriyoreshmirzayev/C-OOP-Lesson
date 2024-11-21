using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP.OOP_1_dars
{
    internal class Uchburchak
    {
        public int eni;
        public int boyi;
        public int balandligi;
        public int asosi;
        public int Perimetri()
        {
            return eni + boyi + balandligi;
        }
        public void UchburchakPerimetri()
        {
            Console.WriteLine($"Uchburchakning Perimetri: " + (eni + boyi + balandligi));
        }
        public int Yuzasi()
        {
            return (asosi * balandligi) / 2;
        }
        public void UchburchakYuzasi()
        {
            Console.WriteLine($"Uchburchakning YUzasi: " + (asosi * balandligi) / 2);
        }
    }
}
