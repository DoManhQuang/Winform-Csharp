using System;
using System.Runtime.Serialization;

namespace BTL_WinForm_Ailatrieuphu.Giao_Dien_Vao_Form
{
    [Serializable]
    internal class ErrorSignUp : Exception
    {
        public ErrorSignUp()
        {
        }

        public ErrorSignUp(string message) : base(message)
        {
        }

        public ErrorSignUp(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ErrorSignUp(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}