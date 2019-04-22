using System;
using System.Runtime.Serialization;

namespace BTL_WinForm_Ailatrieuphu.Nguoi_Choi
{
    [Serializable]
    internal class NameNull : Exception
    {
        public NameNull()
        {
        }

        public NameNull(string message) : base(message)
        {
        }

        public NameNull(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NameNull(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}