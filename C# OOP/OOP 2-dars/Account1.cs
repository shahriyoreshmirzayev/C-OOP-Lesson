namespace C__OOP.OOP_2_dars
{
    internal class Account1
    {
        private int _login;
        private string _name;
        private double _money;
        public int Login
        {
            get { return _login; }
            set
            {
                if (value > 0)
                {
                    _login = value;
                    Console.WriteLine("True");
                }
                else Console.WriteLine("False");
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 5 && value.Any(char.IsLetter))
                {
                    _name = value;
                    Console.WriteLine("True");
                }
                else Console.WriteLine("False");
            }
        }
        public double Money
        {
            get { return _money; }
            set
            {
                if (value > 0)
                {
                    _money = value;
                    Console.WriteLine("True");
                }
                else Console.WriteLine("False");
            }
        }
    }
}
