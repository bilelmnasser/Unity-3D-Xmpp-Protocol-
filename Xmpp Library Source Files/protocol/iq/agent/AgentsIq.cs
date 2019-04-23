using System;
using Xmpp.protocol.client;

// Request Agents:
// <iq id='someid' to='myjabber.net' type='get'>
//		<query xmlns='jabber:iq:agents'/>
// </iq>

namespace Xmpp.protocol.iq.agent
{
	/// <summary>
	/// Summary description for AgentsIq.
	/// </summary>
	public class AgentsIq : IQ
	{
		private Agents m_Agents = new Agents();

		public AgentsIq()
		{
			base.Query = m_Agents;
			this.GenerateId();
		}

		public AgentsIq(IqType type) : this()
		{			
            this.Type = type;		
		}

		public AgentsIq(IqType type, Jid to) : this(type)
		{
			this.To = to;
		}

		public AgentsIq(IqType type, Jid to, Jid from) : this(type, to)
		{
			this.From = from;
		}

		public new Agents Query
		{
			get	{ return m_Agents; }            
		}
	}
}
