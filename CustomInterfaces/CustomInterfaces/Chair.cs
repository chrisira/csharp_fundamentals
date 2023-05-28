using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    internal class Chair : Furniture, IDestroyable
    {
        // Implementint interface property
        public string DestructionSound { get; set; }

        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
            // initialize the interface property with  a value in constructor

            DestructionSound = "ChairExplosionSound.mp3";

        }
        //implementing interface's method
        public void Destroy()
        {
            // when a chari get destroyed we play the destruction sound
            // spawn the destroyed chair parts
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine($"Playing Destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts ");

           
        }

    }
}
