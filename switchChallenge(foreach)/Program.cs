
namespace switchChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean valid = false;
            string inputValueType;
            System.Console.WriteLine("Enter a value : ");
            string inputValue = Console.ReadLine();

            System.Console.WriteLine("Enter the number to validate the input you have entered");
            System.Console.WriteLine("Press 1 for a String");
            System.Console.WriteLine("Press 2 for an integer");
            System.Console.WriteLine("Press 3 for a Boolean");

            Console.Write("Enter number : ");
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch(inputType){
                case 1:
                //check for a string
                valid = IsAllAlphabet(inputValue);
                inputValueType = "string";
                break;
            
                case 2:
                //check for integer
                int retValue = 0;
                valid = int.TryParse(inputValue,out retValue);
                inputValueType = "Integer";
                break;

                case 3:
                //check for boolean
                bool retFlag = false;
                valid = bool.TryParse(inputValue,out retFlag);
                inputValueType = "Boolean";
                break;

                default:
                inputValueType = "Unknown";
                System.Console.WriteLine("The value entered is unknown");
                break;
            
        }
        System.Console.WriteLine("you have entered {0}",inputValue);
        if(valid){
            System.Console.WriteLine("the entered value is valid {0}",inputValueType);
        }else{
            System.Console.WriteLine("This is an invalid {0}",inputValueType);
        }    
        }   
        static bool IsAllAlphabet(string value){
            foreach(char c in value){
                if(!char.IsLetter(c)){
                    return false;
                }     
            }
            return true;
        } 
        
    
}
}