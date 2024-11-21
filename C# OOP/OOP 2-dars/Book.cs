namespace C__OOP.OOP_2_dars
{
    internal class Book
    {
        private string _name;
        private string _author;
        private double _isbn;
        private double _price;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 7 && value.Any(char.IsLetter))
                {
                    _name = value;
                    Console.WriteLine("True");
                }
                else Console.WriteLine("False");
            }
        }
        public string Author
        {
            get { return _author; }
            set
            {
                if (value.Length > 7 && value.Any(Char.IsLetter))
                {
                    Author = value;
                    Console.WriteLine("True");
                }
                else Console.WriteLine("False");
            }
        }
        public double ISBN
        {
            get { return _isbn; }
            set
            {
                if (value > 999999999999 && value < 10000000000000)
                {
                    _isbn = value;
                    Console.WriteLine("True");
                }
                else Console.WriteLine("False");
            }
        }
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 10000)
                {
                    _price = value;
                    Console.WriteLine("True");
                }
                else Console.WriteLine("False");
            }
        }
    }
}
