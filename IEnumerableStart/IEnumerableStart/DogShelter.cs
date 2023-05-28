using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableStart
{
    internal class DogShelter
    {
        // List of type List<Dog>
        public List<Dog> dogs;

        //adding constructor to initialize the dog with some values
        public DogShelter()
        {
            // Initialize the dog list using the collection initializer
            dogs = new List<Dog>()
            {
                new Dog("Casper",false),
                new Dog("Sif",true),
                new Dog("Oreo",false),
                new Dog("Pixel",false)
            };


        }
    }
}
