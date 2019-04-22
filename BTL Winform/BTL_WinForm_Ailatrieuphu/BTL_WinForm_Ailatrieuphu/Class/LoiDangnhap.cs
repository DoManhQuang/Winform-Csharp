using System;
using System.Runtime.Serialization;

namespace BTL_WinForm_Ailatrieuphu
{
    [Serializable]
    internal class LoiDangnhap : Exception
    {
        public LoiDangnhap()
        {
        }

        public LoiDangnhap(string message) : base(message)
        {
        }

        public LoiDangnhap(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LoiDangnhap(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}