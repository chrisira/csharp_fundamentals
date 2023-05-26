namespace CustomInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating 2 objects of type chair
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            //creating new object of type car
            Car damagedCar = new Car(80f, "Blue");

            // adding 2 chairs near the damaged car

            // add the two chairs to the IDestroyable list of the car
            // so that we destroy the car and destroyable objects
            // that near the call will get destroyed as well

            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            // destroy the car 
            damagedCar.Destroy();







        }
    }
}