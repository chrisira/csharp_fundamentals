using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    internal interface IDestroyable
    {
        // Property to store the destruction sound
        public string DestructionSound { get; set; }

        //method to destroy specified object

        void Destroy();
    }
}
