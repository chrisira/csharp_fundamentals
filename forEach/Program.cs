
namespace forEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] nums  =new int[10];
            for(int i = 0;i<10;i++){
               nums[i] = i;
            } 
            // for(int j = 0;j<nums.Length;j++){
             //   System.Console.WriteLine("The value at index {0} is  {1}",j,nums[j]);
             int counter = 0;
             foreach(int k in nums){
            System.Console.WriteLine("the number at index {0} is {1}",counter,k);
            counter++;

            }

            string [] friends = new string[5]{"King Giddy","Elisa","Gatete","Kazadi","Marlene"};

            foreach(string name in friends){
                System.Console.WriteLine("Hello {0}",name);

            }
        }
    
}
}