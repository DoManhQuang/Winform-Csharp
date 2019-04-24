using System;
using System.Runtime.Serialization;

namespace BTL_WinForm_Ailatrieuphu
{
    [Serializable]
    internal class MaKTVNULL : Exception
    {
        public MaKTVNULL()
        {
        }

        public MaKTVNULL(string message) : base(message)
        {
        }

        public MaKTVNULL(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MaKTVNULL(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}