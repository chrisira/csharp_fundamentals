namespace loopsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            double average = 0;
            double sum = 0;
          
            string enteredText = "0";
            while(enteredText!="-1"){
                try{
                System.Console.WriteLine("Enter Marks between 0 and 20");
                enteredText = Console.ReadLine();
                int studentMarks = int.Parse(enteredText);
                if(studentMarks < 20){
                counter++; 
                sum +=studentMarks;
                 average = sum /counter; 
                
                }
                else{
                    System.Console.WriteLine("enter the value between 0 and 20");
                }
                 
            }
            catch(FormatException){
                System.Console.WriteLine("Error");

            }

                }
                System.Console.WriteLine("The average score is {0}",average);
                    }
}      }   
    
