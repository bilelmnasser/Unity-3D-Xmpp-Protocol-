using System;
using Xmpp.protocol.client;

namespace Xmpp.protocol.iq.last
{
	/// <summary>
	/// Summary description for LastIq.
	/// </summary>
	public class LastIq : IQ
	{
		private Last m_Last = new Last();

		public LastIq()
		{		
			base.Query = m_Last;
			this.GenerateId();			
		}

		public LastIq(IqType type) : this()
		{			
			this.Type = type;		
		}

		public LastIq(IqType type, Jid to) : this(type)
		{
			this.To = to;
		}

		public LastIq(IqType type, Jid to, Jid from) : this(type, to)
		{
			this.From = from;
		}

		public new Last Query
		{
			get
			{
				return m_Last;
			}
		}
	}
}
