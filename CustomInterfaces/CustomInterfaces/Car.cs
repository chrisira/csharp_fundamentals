using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    internal class Car:Vehicle,IDestroyable
    {


        //implementing the interface properties

        public string DestructionSound { get; set; }
        /*
        - creating the property to store destroyable objects near by when the car get destroyed
        it should also destroy nearby objects.
        - We create a List of IDestroyable which means can store any object
        that implements this interface and we can only access the properties and methods in this interface

         */

        public List<IDestroyable> DestroyablesNearby;    

        //simple constructor

        public Car(float speed,string color)
        {
            this.Speed = speed;
            this.Color = color;

            // initialize the interface property with  a value in constructor

            DestructionSound = "CarExplosionSound.mp3";

            // initialize the list of destroyable objects

            DestroyablesNearby= new List<IDestroyable>();   


        }
        // Implementing interface method
        public void Destroy()
        {
            // when a car get destroyed we play the destruction sound
            // create a fire effect
            Console.WriteLine("Playing Destruction sound {0}",DestructionSound);
            Console.WriteLine("Create fire");

            // go throuh all destroyable object nearby and call it's destroy method
            foreach(IDestroyable destroyable in  DestroyablesNearby) { 
                destroyable.Destroy();  
            }
        }
        
    }
}
