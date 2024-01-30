using System;
using System.Runtime.Serialization;

namespace SalesProject.Controllers
{
    [Serializable]
    internal class NotFOundException : Exception
    {
        public NotFOundException()
        {
        }

        public NotFOundException(string message) : base(message)
        {
        }

        public NotFOundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotFOundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}