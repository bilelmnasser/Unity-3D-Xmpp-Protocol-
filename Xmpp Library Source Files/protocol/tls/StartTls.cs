using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.tls
{

	// Step 4: Client sends the STARTTLS command to server:
	// <starttls xmlns='urn:ietf:params:xml:ns:xmpp-tls'/>

	/// <summary>
	/// Summary description for starttls.
	/// </summary>
	public class StartTls : Element
	{
		public StartTls()
		{
			this.TagName	= "starttls";
			this.Namespace	= Uri.TLS;
		}

		public bool Required
		{
			get
			{
				return HasTag("required");
			}
			set
			{
				if (value == false)
				{
					if (HasTag("required"))
						RemoveTag("required");
				}
				else
				{
					if (!HasTag("required"))
						SetTag("required");
				}
			}
		}
	}
}
