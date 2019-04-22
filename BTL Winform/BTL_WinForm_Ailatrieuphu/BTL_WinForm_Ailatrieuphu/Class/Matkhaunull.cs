using System;
using System.Runtime.Serialization;

namespace BTL_WinForm_Ailatrieuphu
{
    [Serializable]
    internal class Matkhaunull : Exception
    {
        public Matkhaunull()
        {
        }

        public Matkhaunull(string message) : base(message)
        {
        }

        public Matkhaunull(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Matkhaunull(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}