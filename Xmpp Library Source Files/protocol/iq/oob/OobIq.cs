using System;
using Xmpp.protocol.client;

namespace Xmpp.protocol.iq.oob
{
	/// <summary>
	/// Summary description for OobIq.
	/// </summary>
	public class OobIq : IQ
	{
		private Oob m_Oob = new Oob();

		public OobIq()
		{		
			base.Query = m_Oob;
			this.GenerateId();
		}

		public OobIq(IqType type) : this()
		{			
			this.Type = type;		
		}

		public OobIq(IqType type, Jid to) : this(type)
		{
			this.To = to;
		}

		public OobIq(IqType type, Jid to, Jid from) : this(type, to)
		{
			this.From = from;
		}

		public new Oob Query
		{
			get
			{
				return m_Oob;
			}
		}
	}
}
