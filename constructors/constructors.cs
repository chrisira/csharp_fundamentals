namespace constructors
{
    class Human
    {
        //member variables
        private string firstName = "";
        private string lastName = "";
        private string eyeColor = "";
        private int age = 0;

        //non parameterized constructors(default constructor)
        public Human(){
            System.Console.WriteLine("The constructor is called object is created");
        }

        //parameterized constructors
        public Human(string firstName,string lastName,string eyeColor,int age){
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

         public Human(string firstName,string lastName,string eyeColor){
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
           
        }
        
        //member method
        public void IntroduceMyself(){
            if(age != 0){
                System.Console.WriteLine("Hello I am {0} {1} I have {2} eyes and I am {3}",firstName,lastName,eyeColor,age);
            }
            else{
                System.Console.WriteLine("Hello I am {0} {1} I have {2} eyes ",firstName,lastName,eyeColor);
            }
            
        }
    }
}