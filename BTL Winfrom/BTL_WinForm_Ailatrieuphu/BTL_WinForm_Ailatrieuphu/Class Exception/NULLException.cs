using System;
using System.Runtime.Serialization;

namespace BTL_WinForm_Ailatrieuphu.Nguoi_Choi
{
    [Serializable]
    internal class NULLException : Exception
    {
        public NULLException()
        {
        }

        public NULLException(string message) : base(message)
        {
        }

        public NULLException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NULLException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}