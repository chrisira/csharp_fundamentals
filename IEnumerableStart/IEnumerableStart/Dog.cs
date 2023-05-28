using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableStart
{
    internal class Dog
    {
        public string Name { get; set; }

        public bool IsNaughtyDog { get; set; }


        //adding a constructor
        public Dog(string name, bool isNaughtyDog) {
            this.Name= name;
            this.IsNaughtyDog= isNaughtyDog;
        }
        //adding the method that will count how many numbers a dog get treated

        public void GiveTreat(int NumberOfTreats)
        {
            // adding the message to be displayed each time the dog get treated
            Console.WriteLine("Dog : {0} said wouf {1} times .",Name,NumberOfTreats);

        }
    }
}
