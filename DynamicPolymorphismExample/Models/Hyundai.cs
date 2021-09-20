namespace DynamicPolymorphismExample.Models
{
    class Hyundai : IProductCar
    {
        public string Color
        {
            get { return "White"; }
        }

        public string Model
        {
            get { return "HYUNDAI i30"; }
        }

        public string Name
        {
            get { return "Electric"; }
        }
    }
}
