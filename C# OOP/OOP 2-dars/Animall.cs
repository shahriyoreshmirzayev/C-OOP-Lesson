namespace C__OOP.OOP_2_dars
{
     class Animall
    {
        public string name { get; set; }
        public int legs { get; set; }
        public string color { get; set; }
    }
    class Dog : Animall
    {
        public void SpeakDog()
        {
            Console.WriteLine("Waaw");
        }
    }
    class Cat : Dog
    {
        private void SpeakCat()
        {
           // base.SpeakDog();
            Console.WriteLine("Myoow");
        }
        public void CallSpeakCat()
        {
            this.SpeakCat();
            Console.WriteLine("Wooow");
        }
    }
}
