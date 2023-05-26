using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    internal class Car:Vehicle
    {
        //simple constructor

        public Car(float speed,string color)
        {
            this.Speed = speed;
            this.Color = color;

        }
    }
}
