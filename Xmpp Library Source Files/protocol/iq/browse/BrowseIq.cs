using System;
using Xmpp.protocol.client;

namespace Xmpp.protocol.iq.browse
{
	/// <summary>
	/// Summary description for BrowseIq.
	/// </summary>
	public class BrowseIq : IQ
	{
		private Browse m_Browse	= new Browse();
		
		public BrowseIq()
		{		
			base.Query = m_Browse;
			this.GenerateId();			
		}

		public BrowseIq(IqType type) : this()
		{			
			this.Type = type;		
		}

		public BrowseIq(IqType type, Jid to) : this(type)
		{
			this.To = to;
		}

		public BrowseIq(IqType type, Jid to, Jid from) : this(type, to)
		{
			this.From = from;
		}

		public new Browse Query
		{
			get
			{
				return m_Browse;
			}
		}
	}
}
