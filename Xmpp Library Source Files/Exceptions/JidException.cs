using System;

namespace Xmpp.Exceptions
{
    public class JidException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public JidException()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public JidException(string msg) : base(msg)
        {

        }
    }
}