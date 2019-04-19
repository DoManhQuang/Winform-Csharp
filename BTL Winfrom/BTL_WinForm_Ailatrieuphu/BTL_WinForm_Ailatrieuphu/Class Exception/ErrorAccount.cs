using System;
using System.Runtime.Serialization;

namespace BTL_WinForm_Ailatrieuphu.Giao_Dien_Vao_Form
{
    [Serializable]
    internal class ErrorAccount : Exception
    {
        public ErrorAccount()
        {
        }

        public ErrorAccount(string message) : base(message)
        {
        }

        public ErrorAccount(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ErrorAccount(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}