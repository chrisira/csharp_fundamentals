namespace ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = 90;
            string stateOfMatter;
            stateOfMatter = temperature <0 ? "Solid" : temperature >100 ? "Gas":"liquid";
            System.Console.WriteLine("the state of matter is {0}",stateOfMatter);

        }
    }
}