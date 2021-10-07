using System;
using System.Runtime.Serialization;

namespace LAB1_Capraru_Emil_Ionut.Domain
{
    [Serializable]
    internal class Invalid_quantity: Exception
    {
        public Invalid_quantity()
        {
        }

        public Invalid_quantity(string? message) : base(message)
        {
        }

        public Invalid_quantity(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected Invalid_quantity(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}