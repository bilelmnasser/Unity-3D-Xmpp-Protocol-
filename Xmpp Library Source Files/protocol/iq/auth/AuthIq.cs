using System;

using Xmpp.protocol.client;

namespace Xmpp.protocol.iq.auth
{
	/// <summary>
	/// Summary description for AuthIq.
	/// </summary>
	public class AuthIq : IQ
	{
		private Auth m_Auth	= new Auth();
		
		public AuthIq()
		{		
			base.Query = m_Auth;
			this.GenerateId();			
		}

		public AuthIq(IqType type) : this()
		{			
			this.Type = type;		
		}

		public AuthIq(IqType type, Jid to) : this(type)
		{
			this.To = to;
		}

		public AuthIq(IqType type, Jid to, Jid from) : this(type, to)
		{
			this.From = from;
		}

		public new Auth Query
		{
			get
			{
				return m_Auth;
			}
		}
	}
}
