using System;

namespace DynamicPolymorphismExample
{
    class Program
    {
        static void Main(string[] args)
        {

            IProductCar productCar = null;
            CarModelFactory carModelFactory = null;
            Console.WriteLine("Enter the car type|electric, mechanic|");
            var inputCarType = Console.ReadLine();
            try
            {
                carModelFactory = FactorySelection.CreateCarFactory(inputCarType);

                if (inputCarType.ToLower() == "electric")
                    Console.WriteLine("Choose the car |Tesla,Nissan,Jaguar|");
                else if (inputCarType.ToLower() == "mechanic")
                    Console.WriteLine("Choose the car |BMW,Ford,Hyundai|");

                var inputCar = Console.ReadLine();
                productCar = carModelFactory.GetCarInstance(inputCar);

                Console.WriteLine($"|The car type| {productCar.Name} |Model| {productCar.Model}|Color|{productCar.Color}");
            }
            catch (CarException ex)
            {
                Console.WriteLine("Error message is: " + ex.Message);
            }
        }
    }
}
