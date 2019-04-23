using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.x
{
	/*
	<message from='crone1@shakespeare.lit/desktop' to='hecate@shakespeare.lit'>
		<body>You have been invited to darkcave@macbeth.</body>
		<x jid='room@service' xmlns='jabber:x:conference'/>
	</message>
	*/

	/// <summary>
	/// is used for inviting somebody to a chatroom
	/// </summary>
	public class Conference : Element
	{
		public Conference()
		{
			this.TagName	= "x";
			this.Namespace	= Uri.X_CONFERENCE;
		}

		public Conference(Jid room) : this()
		{
			Chatroom = room;
		}

		/// <summary>
		/// Room Jid
		/// </summary>
		public Jid Chatroom
		{
			get { return new Jid(GetAttribute("jid")); }
			set { SetAttribute("jid", value.ToString()); }
		}
	}
}
