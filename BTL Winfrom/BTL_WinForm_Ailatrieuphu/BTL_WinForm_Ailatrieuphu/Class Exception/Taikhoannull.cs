using System;
using System.Runtime.Serialization;

namespace BTL_WinForm_Ailatrieuphu
{
    [Serializable]
    internal class Taikhoannull : Exception
    {
        public Taikhoannull()
        {
        }

        public Taikhoannull(string message) : base(message)
        {
        }

        public Taikhoannull(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Taikhoannull(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}