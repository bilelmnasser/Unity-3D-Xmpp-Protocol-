using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.primary
{
	/// <summary>
	/// http://www.jabber.org/jeps/inbox/primary.html
	/// </summary>
	public class Primary : Element
	{
		/*
		<presence from='juliet@capulet.com/balcony'>
			<status>I&apos;m back!</status>
			<p xmlns='http://jabber.org/protocol/primary'/>
		</presence>
		*/

		public Primary()
		{
			this.TagName	= "p";
			this.Namespace	= Uri.PRIMARY;
		}
	}
}
