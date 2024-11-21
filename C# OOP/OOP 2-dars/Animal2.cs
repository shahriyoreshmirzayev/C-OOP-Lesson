namespace C__OOP.OOP_2_dars
{
    internal class Animal2
    {
        public string name { get; set; }
        public int legs { get; set; }
        public string color { get; set; }
    }
    class Dog1 : Animal2
    {
        public void DogSpeak()
        {
            Console.WriteLine("Waaw");
        }
    }
    class Cat2 : Dog1
    {
        private void CatSpeak()
        {
            base.DogSpeak();
            Console.WriteLine("Myoow");
        }
        public void CallSpeakCat2()
        {
            this.DogSpeak();
            Console.WriteLine("Myoww2");
        }
    }
}
