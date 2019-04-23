using System;

namespace Xmpp.protocol.component
{
    /// <summary>
    /// Summary description for Error.
    /// </summary>
    public class Error : Xmpp.protocol.client.Error
    {
        public Error() : base()
        {
            this.Namespace = Uri.ACCEPT;
        }
                
        public Error(int code)
            : base(code)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Error(Xmpp.protocol.client.ErrorCode code)
            : base(code)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Error(Xmpp.protocol.client.ErrorType type)
            : base(type)
        {
            this.Namespace = Uri.ACCEPT;
        }

        /// <summary>
        /// Creates an error Element according the the condition
        /// The type attrib as added automatically as decribed in the XMPP specs
        /// This is the prefered way to create error Elements
        /// </summary>
        /// <param name="condition"></param>
        public Error(Xmpp.protocol.client.ErrorCondition condition)
            : base(condition)
        {
            this.Namespace = Uri.ACCEPT;
        }
    }
}
