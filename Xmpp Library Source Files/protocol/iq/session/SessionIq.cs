using System;

using Xmpp.protocol.client;

namespace Xmpp.protocol.iq.session
{
	/// <summary>
	/// Starting the session, this is done after resource binding
	/// </summary>
	public class SessionIq : IQ
	{
		/*
		SEND:	<iq xmlns="jabber:client" id="agsXMPP_2" type="set" to="jabber.ru">
					<session xmlns="urn:ietf:params:xml:ns:xmpp-session" />
				</iq>
		RECV:	<iq xmlns="jabber:client" from="jabber.ru" type="result" id="agsXMPP_2">
					<session xmlns="urn:ietf:params:xml:ns:xmpp-session" />
				</iq> 
		 */
		private Session m_Session = new Session();
		
		public SessionIq()
		{
			this.GenerateId();
			this.AddChild(m_Session);
		}

		public SessionIq(IqType type) : this()
		{			
			this.Type = type;		
		}

		public SessionIq(IqType type, Jid to) : this()
		{			
			this.Type = type;
			this.To = to;
		}		
	}
}
