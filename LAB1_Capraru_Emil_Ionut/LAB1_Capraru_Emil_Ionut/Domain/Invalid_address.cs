using System;
using System.Runtime.Serialization;

namespace LAB1_Capraru_Emil_Ionut.Domain
{
    [Serializable]
    internal class Invalid_address : Exception
    {
        public Invalid_address()
        {
        }

        public Invalid_address(string? message) : base(message)
        {
        }

        public Invalid_address(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected Invalid_address(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}