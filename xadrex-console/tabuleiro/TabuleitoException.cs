using System;
using System.Runtime.Serialization;

namespace tabuleiro
{
    [Serializable]
    internal class TabuleitoException : Exception
    {
        public TabuleitoException()
        {
        }

        public TabuleitoException(string message) : base(message)
        {
        }

        public TabuleitoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TabuleitoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}