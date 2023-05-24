
namespace array
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
             int [] grades =new int[5];
             grades[0] = 20;
             grades[1] = 15;
             grades[2] = 30;
             grades[3] = 24;
             grades[4] = 23;

             System.Console.WriteLine("the marks at index 0 is {0}",grades[0]);
             System.Console.WriteLine("Enter the number of grade");
             string input = Console.ReadLine();

             int cleanInput =int.Parse(input);
            grades[0] = cleanInput;

            System.Console.WriteLine("The new value at index 0 is {0}",grades[0]);

            //another way of initializing the array

            int[] gradesOfMathStudents = {20,34,30,56,56,64,345,345};
            
            int totalEntries = gradesOfMathStudents.Length;

            System.Console.WriteLine("You have {0} Entries in the array",totalEntries);

            // third way of initializing data into the array

            int[] gradesOfPhysicsStudent = new int[] {12,34,43,45,34,44,40};


        }
    }
}