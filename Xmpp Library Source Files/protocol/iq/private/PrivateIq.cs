using System;

using Xmpp.protocol.client;

namespace Xmpp.protocol.iq.@private
{
	/// <summary>
	/// Summary description for PrivateIq.
	/// </summary>
	public class PrivateIq : IQ
	{
		Private m_Private	= new Private();

		public PrivateIq()
		{
			base.Query = m_Private;
			this.GenerateId();
		}

		public PrivateIq(IqType type) : this()
		{			
			this.Type = type;		
		}

		public PrivateIq(IqType type, Jid to) : this(type)
		{
			this.To = to;
		}

		public PrivateIq(IqType type, Jid to, Jid from) : this(type, to)
		{
			this.From = from;
		}

		public new Private Query
		{
			get { return m_Private; }
		}
	}
}
