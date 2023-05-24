namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string temperature;
            System.Console.WriteLine("The the value of temperature in celcius : ");
            temperature = Console.ReadLine();
            try{
                int celcius = int.Parse(temperature);

                string message = celcius<=15 ? "Too  old here":celcius >=16 && celcius <=28 ? "It is Ok":"It is hoter here";
                System.Console.WriteLine(message);


            }
            catch(FormatException){
                System.Console.WriteLine("The temparature value is not valid");

            }
            catch(OverflowException){
                System.Console.WriteLine("The value is too big for the temperature");
            }
            catch(ArgumentNullException){
                System.Console.WriteLine("Values cannot be empty");
            }
        }
    }
}