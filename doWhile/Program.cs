namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            do{
                System.Console.WriteLine("Counter is {0}",counter);
                counter++;
            }
            while(counter <20);
        }
    }
}