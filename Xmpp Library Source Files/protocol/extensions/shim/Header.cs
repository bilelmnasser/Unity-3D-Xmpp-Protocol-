using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.shim
{

	/// <summary>
	/// JEP-0131: Stanza Headers and Internet Metadata (SHIM)
	/// </summary>
	public class Header : Element
	{
		// <headers xmlns='http://jabber.org/protocol/shim'>
		//	 <header name='In-Reply-To'>123456789@capulet.com</header>
		// <header name='Keywords'>shakespeare,&lt;xmpp/&gt;</header>
		// </headers>
		#region << Constructors >>
		public Header()
		{
			this.TagName	= "header";
			this.Namespace	= Uri.SHIM;			
		}

		public Header(string name, string val) : this()
		{
			this.Name	= name;
			this.Value	= val;
		}
		#endregion

		public string Name
		{
			get { return GetAttribute("name"); }
			set { SetAttribute("name", value); }
		}
	}
}