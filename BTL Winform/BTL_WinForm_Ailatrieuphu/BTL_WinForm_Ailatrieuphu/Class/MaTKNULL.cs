using System;
using System.Runtime.Serialization;

namespace BTL_WinForm_Ailatrieuphu.Giao_Dien_Vao_Form
{
    [Serializable]
    internal class MaTKNULL : Exception
    {
        public MaTKNULL()
        {
        }

        public MaTKNULL(string message) : base(message)
        {
        }

        public MaTKNULL(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MaTKNULL(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}