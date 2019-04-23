using System;

using Xmpp.protocol;
using Xmpp.protocol.client;

namespace Xmpp.protocol.iq.disco
{
	/// <summary>
	/// Discovering Information About a Jabber Entity
	/// </summary>
	public class DiscoInfoIq : IQ
	{
		private DiscoInfo m_DiscoInfo = new DiscoInfo();
		
		public DiscoInfoIq()
		{
			base.Query = m_DiscoInfo;
			this.GenerateId();
		}

		public DiscoInfoIq(IqType type) : this()
		{			
			this.Type = type;		
		}	

		public new DiscoInfo Query
		{
			get
			{
				return m_DiscoInfo;
			}
		}
	}
}
