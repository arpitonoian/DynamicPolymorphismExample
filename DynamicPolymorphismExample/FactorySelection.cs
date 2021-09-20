using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphismExample
{
    class FactorySelection
    {
        public static CarModelFactory CreateCarFactory(string FactoryType)
        {
            if (FactoryType.ToLower() == "electric")
            
                return new ElectricCarFactory();

            else if (FactoryType.ToLower() == "mechanic")

                return new MechanicCarFactory();

            else if (FactoryType == null)

                throw new CarException("Parameter cannot be null");

            throw new CarException("Incorrectly entered data");

        }
    }
}
