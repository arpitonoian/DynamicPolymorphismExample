using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphismExample
{
    public abstract class CarModelFactory
    {
        public abstract IProductCar GetCarInstance(string CarType);
    }
}
