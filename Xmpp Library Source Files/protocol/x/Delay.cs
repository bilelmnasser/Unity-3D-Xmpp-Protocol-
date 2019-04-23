

using System;
using Xmpp.Xml.Dom;

namespace Xmpp.protocol.x
{
	// <presence to="gnauck@myjabber.net/myJabber v3.5" from="yahoo.myjabber.net/registered">
	//		<status>Extended Away</status>
	//		<show>xa</show><priority>5</priority>
	//		<x stamp="20050206T13:09:50" from="gnauck@myjabber.net/myJabber v3.5" xmlns="jabber:x:delay"/>    
	// </presence> 

	/// <summary>
    /// <para>
	/// Delay class for Timestamps
    /// </para>
    /// <para>
    /// Mainly used in offline and groupchat messages. This is the time when the message was received by the server
    /// </para>
	/// </summary>
	public class Delay : Element
	{
		public Delay()
		{
			this.TagName	= "x";
			this.Namespace	= Uri.X_DELAY;
		}

		public Jid From
		{
			get
			{
				if (HasAttribute("from"))
					return new Jid(GetAttribute("from"));
				else
					return null;
			}
			set
			{
				SetAttribute("from", value.ToString());
			}
		}

		public DateTime Stamp
		{
			get
			{
				return Util.Time.Date(GetAttribute("stamp"));
			}
			set
			{
				SetAttribute("stamp", Util.Time.Date(value));
			}
		}
	}
}
