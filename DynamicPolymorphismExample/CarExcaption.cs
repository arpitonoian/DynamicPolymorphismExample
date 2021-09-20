using System;


namespace DynamicPolymorphismExample
{
    [Serializable]
    public class CarException : Exception
    {
         private static readonly string defaultMessage = "An error occurred while entering the name in DynamicPolymorphismExample․";

        public CarException() { }
        public CarException(string message) : base(message) { }
        public CarException(string message, Exception inner) : base(message, inner) { }
        protected CarException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
