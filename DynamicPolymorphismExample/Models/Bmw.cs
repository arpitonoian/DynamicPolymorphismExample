namespace DynamicPolymorphismExample.Models
{
    class Bmw : IProductCar
    {
        public string Color
        {
            get { return "Yellow"; }
        }

        public string Model
        {
            get { return "BMW X7"; }
        }

        public string Name
        {
            get { return "Mechanic"; }
        }
    }
}

