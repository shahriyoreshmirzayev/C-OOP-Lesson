using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP.OOP_2_dars
{
    internal class AccountTG
    {
        private string Name;
        private string Age;
        private double Money;

        public AccountTG(string name, string age, double money = 0)
        {
            Name = name;
            Age = age;
            Money = money;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
       

    }
}
