namespace classBasics
{
    class Program
    {
        static void Main(string[] args)
        {
        //     //create an object of the class
        //     Human denis = new Human();
        //     //access public variables from outside
        //     denis.firstName = "Denis";
        //     denis.lastName = "Panjuta";
        //    //Calling the method
        //     denis.IntroduceMyself();

        //     Human christian = new Human();

        //     christian.firstName = "IRADUKUNDA";
        //     christian.lastName = "Christian";
        //     christian.IntroduceMyself();

        //using constructors

        Human christian = new Human("Christian","IRADUKUNDA","black",34);
        christian.IntroduceMyself();

        }
    }
}