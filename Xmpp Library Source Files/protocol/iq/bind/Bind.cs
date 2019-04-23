using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.bind
{
	/// <summary>
	/// Summary description for Bind.
	/// </summary>
	public class Bind : Element
	{
		// SENT: <iq id="jcl_1" type="set">
		//			<bind xmlns="urn:ietf:params:xml:ns:xmpp-bind"><resource>Exodus</resource></bind>
		//		 </iq>
		// RECV: <iq id='jcl_1' type='result'>
		//			<bind xmlns='urn:ietf:params:xml:ns:xmpp-bind'><jid>user@server.org/agsxmpp</jid></bind>
		//		 </iq>
		public Bind()
		{
			this.TagName	= "bind";
			this.Namespace	= Uri.BIND;
		}

		public Bind(string resource) : this()
		{		
			this.Resource	= resource;
		}

		public Bind(Jid jid) : this()
		{			
			this.Jid		= jid;
		}

		/// <summary>
		/// The resource to bind
		/// </summary>
		public string Resource
		{
			get { return GetTag("resource"); }
			set { SetTag("resource", value); }
		}

		/// <summary>
		/// The jid the server created
		/// </summary>
		public Jid Jid
		{
			get { return GetTagJid("jid"); }
			set { SetTag("jid", value.ToString()); }
		}
	}
}
