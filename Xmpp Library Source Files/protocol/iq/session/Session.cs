using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.session
{
	/// <summary>
	/// Summary description for Session.
	/// </summary>
	public class Session : Element
	{
		public Session()
		{
			this.TagName	= "session";
			this.Namespace	= Uri.SESSION;
		}
	}
}
