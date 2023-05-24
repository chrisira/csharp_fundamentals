namespace classBasics
{
    class Human
    {
        //member variables
        private string firstName = "";
        private string lastName = "";
        private string eyeColor = "";
        private int age = 0;

        public Human(string firstName,string lastName,string eyeColor,int age){
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }
        
        //member method
        public void IntroduceMyself(){
            System.Console.WriteLine("Hello I am {0} {1} I have {2} eyes and I am {3}",firstName,lastName,eyeColor,age);
        }
    }
}