using System;
using System.Runtime.Serialization;

namespace BTL_WinForm_Ailatrieuphu
{
    [Serializable]
    internal class MaQLVNULL : Exception
    {
        public MaQLVNULL()
        {
        }

        public MaQLVNULL(string message) : base(message)
        {
        }

        public MaQLVNULL(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MaQLVNULL(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}