using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.tls
{
	// Step 5: Server informs client that it is allowed to proceed:
	// <proceed xmlns='urn:ietf:params:xml:ns:xmpp-tls'/>

	/// <summary>
	/// Summary description for Proceed.
	/// </summary>
	public class Proceed : Element
	{
		public Proceed()
		{
			this.TagName	= "proceed";
			this.Namespace	= Uri.TLS;
		}
	}
}
