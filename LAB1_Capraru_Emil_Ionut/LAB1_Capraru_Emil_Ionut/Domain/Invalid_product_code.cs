using System;
using System.Runtime.Serialization;

namespace LAB1_Capraru_Emil_Ionut.Domain
{
    [Serializable]
    internal class Invalid_product_code : Exception
    {
        public Invalid_product_code()
        {
        }

        public Invalid_product_code(string? message) : base(message)
        {
        }

        public Invalid_product_code(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected Invalid_product_code(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
