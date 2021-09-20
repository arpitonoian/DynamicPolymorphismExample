using DynamicPolymorphismExample.Models;

namespace DynamicPolymorphismExample
{
    class ElectricCarFactory : CarModelFactory
    {
        public override IProductCar GetCarInstance(string CarType)
        {
            switch (CarType.ToLower())
            {
                case "nissan":
                    return new Nissan();
                case "tesla":
                    return new Tesla();
                case "jaguar":
                    return new Jaguar();
                case "":
                    throw new CarException("Parameter cannot be null");
                default:
                    throw new CarException("Incorrectly entered data");
            }
        }
    }
}
