namespace DynamicPolymorphismExample.Models
{
    class Tesla : IProductCar
    {
        public string Color
        {
            get { return "Red"; }
        }

        public string Model
        {
            get { return "Tesla Model 3"; }
        }

        public string Name
        {
            get { return "Electric"; }
        }
    }
}
