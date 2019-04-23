using System;

using Xmpp.protocol.client;

namespace Xmpp.protocol.iq.register
{
	/// <summary>
	/// Used for registering new usernames on Jabber/XMPP Servers
	/// </summary>
	public class RegisterIq : IQ
	{
		private Register m_Register = new Register();

		public RegisterIq()
		{
			base.Query = m_Register;
			this.GenerateId();
		}

		public RegisterIq(IqType type) : this()
		{			
			this.Type = type;		
		}

		public RegisterIq(IqType type, Jid to) : this(type)
		{
			this.To = to;
		}

		public RegisterIq(IqType type, Jid to, Jid from) : this(type, to)
		{
			this.From = from;
		}

		public new Register Query
		{
			get
			{
				return m_Register;
			}           
		}
	}
}