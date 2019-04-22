using System;
using System.Runtime.Serialization;

namespace BTL_WinForm_Ailatrieuphu.Giao_Dien_Vao_Form
{
    [Serializable]
    internal class NullAccount : Exception
    {
        public NullAccount()
        {
        }

        public NullAccount(string message) : base(message)
        {
        }

        public NullAccount(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NullAccount(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}