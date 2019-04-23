using System;
using Xmpp.protocol.client;

namespace Xmpp.protocol.iq.version
{	
	/// <summary>
	/// Summary description for VersionIq.
	/// </summary>
	public class VersionIq : IQ
	{
		private Version m_Version = new Version();

		public VersionIq()
		{		
			base.Query = m_Version;
			this.GenerateId();
		}

		public VersionIq(IqType type) : this()
		{			
			this.Type = type;		
		}

		public VersionIq(IqType type, Jid to) : this(type)
		{
			this.To = to;
		}

		public VersionIq(IqType type, Jid to, Jid from) : this(type, to)
		{
			this.From = from;
		}

		public new Version Query
		{
			get { return m_Version;	}
		}
	}
}