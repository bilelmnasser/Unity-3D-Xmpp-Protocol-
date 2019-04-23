using System;
using System.IO;
using System.Text;

using Xmpp;
using Xmpp.Xml.Dom;
using Xmpp.protocol.sasl;

namespace Xmpp.Sasl.Plain
{
	/// <summary>
	/// Summary description for PlainMechanism.
	/// </summary>
	public class PlainMechanism : Mechanism
	{
		private XmppClientConnection m_XmppClient	= null;

		public PlainMechanism()
		{			
		}

		public override void Init(XmppClientConnection con)
		{
			m_XmppClient = con;
			
			// <auth mechanism="PLAIN" xmlns="urn:ietf:params:xml:ns:xmpp-sasl">$Message</auth>
			m_XmppClient.Send(new protocol.sasl.Auth(protocol.sasl.MechanismType.PLAIN, Message()));
		}

		public override void Parse(Node e)
		{
			// not needed here in PLAIN mechanism
		}


		private string Message()
		{	  
			// NULL Username NULL Password
			StringBuilder sb = new StringBuilder();
			
			//sb.Append( (char) 0 );
			//sb.Append(this.m_XmppClient.MyJID.Bare);
			
			sb.Append( (char) 0 );
			sb.Append(this.Username);
			sb.Append( (char) 0 );
			sb.Append(this.Password);
			
			byte[] msg = Encoding.UTF8.GetBytes(sb.ToString());
			return Convert.ToBase64String(msg, 0, msg.Length);
		}
	}
}