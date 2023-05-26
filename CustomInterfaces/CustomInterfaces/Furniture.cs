using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    internal class Furniture
    {
        public string Color { get; set; }

        public string Material { get; set; }


        //Default constructor
        public Furniture()
        {
            Color = "White";
            Material = "Wood";
        }

        // Simple Constructor
        public Furniture(string color, string material)
        {
            Color= color;
            Material = material;    


        }
    }

    
}
