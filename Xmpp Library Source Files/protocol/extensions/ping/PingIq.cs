using System;
using Xmpp.protocol;
using Xmpp.protocol.client;

namespace Xmpp.protocol.extensions.ping
{
	/// <summary>
	/// 
	/// </summary>
	public class PingIq : IQ
	{
		private Ping m_Ping = new Ping();

        #region << Constructors >>
        public PingIq()
		{		
			base.Query = m_Ping;
			this.GenerateId();
		}

        public PingIq(Jid to) : this()
        {
            To = to;
        }

        public PingIq(Jid to, Jid from) : this()
        {
            To      = to;
            From    = from;
        }
        #endregion

    
        public new Ping Query
        {
            get { return m_Ping; }
        }
	}
}
