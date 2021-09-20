using DynamicPolymorphismExample.Models;

namespace DynamicPolymorphismExample
{
    class MechanicCarFactory : CarModelFactory
    {
        public override IProductCar GetCarInstance(string CarType)
        {
            switch (CarType.ToLower())
            {
                case "hyundai":
                    return new Hyundai();
                case "bmw":
                    return new Bmw();
                case "ford":
                    return new Ford();
                case "":
                    throw new CarException("Parameter cannot be null");
                default:
                    throw new CarException("Incorrectly entered data");
            }
        }
    }
}
