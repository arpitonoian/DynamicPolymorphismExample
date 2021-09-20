namespace DynamicPolymorphismExample.Models
{
    class Jaguar : IProductCar
    {
        public string Color
        {
            get { return "White"; }
        }
        public string Model
        {
            get { return "Jaguar I-Pace"; }
        }

        public string Name
        {
            get { return "Electric"; }
        }
    }
}
