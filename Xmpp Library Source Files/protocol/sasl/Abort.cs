using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.sasl
{
	/// <summary>
	/// Summary description for Abort.
	/// </summary>
	public class Abort : Element
	{
		public Abort()
		{
			this.TagName	= "abort";
			this.Namespace	= Uri.SASL;
		}
	}
}
