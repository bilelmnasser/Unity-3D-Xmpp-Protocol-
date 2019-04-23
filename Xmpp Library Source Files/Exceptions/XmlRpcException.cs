using System;

namespace Xmpp.Exceptions
{
    public class XmlRpcException : Exception
    {
        public XmlRpcException() : base()
        {
        }

        public XmlRpcException(string msg) : base(msg)
        {
        }

        public XmlRpcException(int code, string msg) : base(msg)
        {
            this.m_Code = code;
        }

        private int m_Code;

        public int Code
        {
            get { return m_Code; }
            set { m_Code = value; }
        }

    }
}
