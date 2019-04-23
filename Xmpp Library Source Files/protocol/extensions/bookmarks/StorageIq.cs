using System;

using Xmpp.Xml.Dom;

using Xmpp.protocol.client;
using Xmpp.protocol.iq.@private;

namespace Xmpp.protocol.extensions.bookmarks
{
    /// <summary>
    /// 
    /// </summary>
    public class StorageIq : PrivateIq
    {
        public StorageIq()
        {
            this.Query.AddChild(new Storage());
        }

        public StorageIq(IqType type) : this()
		{			
			this.Type = type;		
		}

		public StorageIq(IqType type, Jid to) : this(type)
		{
			this.To = to;
		}

        public StorageIq(IqType type, Jid to, Jid from) : this(type, to)
		{
			this.From = from;
		}

    }
}
