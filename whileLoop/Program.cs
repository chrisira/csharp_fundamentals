namespace whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string enteredText = "";
            while(enteredText.Equals("")){
                System.Console.WriteLine("Enter the line to count,write any other to quit");
                enteredText = Console.ReadLine();
                counter++; 
                Console.WriteLine("the number of count is {0}",counter);

            }
            System.Console.WriteLine("There are {0} int the bus,Good bye!",counter);
        }
    }
}