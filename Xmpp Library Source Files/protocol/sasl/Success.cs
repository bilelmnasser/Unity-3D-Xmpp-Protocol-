using System;

using Xmpp.Xml.Dom;

// <success xmlns='urn:ietf:params:xml:ns:xmpp-sasl'/>
namespace Xmpp.protocol.sasl
{
	/// <summary>
	/// Summary description for Success.
	/// </summary>
	public class Success : Element
	{
		public Success()
		{
			this.TagName	= "success";
			this.Namespace	= Uri.SASL;
		}
	}
}
