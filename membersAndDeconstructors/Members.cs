
namespace membersAndDecontructors
{
    class Members
    {
        //member private methods
        private string memberName="";
        private string jobTitle="";
        private int salary = 0;
        //member public field
        public int age= 0;
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set{
                jobTitle = value;
            }
        }
        public void Introducing(bool isFriend){
            if(isFriend){
                  sharePrivateInfo();
            }
            else{
                System.Console.WriteLine("Hello my name is {0} and my jobtitle is {1}",memberName,JobTitle);
            }
        }
        public void sharePrivateInfo(){
            System.Console.WriteLine("My salary is {0}",salary);
        }
        // member constructor
        public  Members(){
            memberName = "Chris";
            age = 23;
            JobTitle = "Developer";
            salary = 34000;
        }
        //member finalizer deconstructor
        ~Members(){
            //cleanup statements
            Console.WriteLine("Deconstruction of members objects");    
        }

    }
}