namespace constructors
{
    class Program
    {
        static void Main(string[] args)
        {
        Human christian = new Human("Christian","IRADUKUNDA","black");
        christian.IntroduceMyself();
        Human newBasicHuman = new Human();
        newBasicHuman.IntroduceMyself();

        }
    }
}