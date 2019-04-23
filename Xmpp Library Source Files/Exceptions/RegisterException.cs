using System;
namespace Xmpp.Exceptions
{
    public class RegisterException : Exception
    {
        public RegisterException()
        {
        }

        public RegisterException(string msg) : base(msg)
        {

        }
    }
}