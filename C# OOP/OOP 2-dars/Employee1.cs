namespace C__OOP.OOP_2_dars
{
    internal class Employee1
    {
        private int _id;
        private string _name;
        private string _surname;
        private double _money;
        public int ID
        {
            get { return _id; }
            set
            {
                if (value > 0)
                {
                    _id = value;
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
                if (value.Length > 5 && value.All(char.IsLetter))
                {
                    _name = value;
                    Console.WriteLine("True");
                }
                else Console.WriteLine("False");
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length > 7 && value.All(char.IsLetter))
                {
                    _surname = value;
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
                else Console.WriteLine("false");
            }
        }
    }
}
