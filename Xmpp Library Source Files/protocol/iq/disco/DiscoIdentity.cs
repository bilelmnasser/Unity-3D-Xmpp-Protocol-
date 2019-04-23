using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.disco
{
	/*
	<iq type='result'
	from='plays.shakespeare.lit'
	to='romeo@montague.net/orchard'
	id='info1'>
	<query xmlns='http://jabber.org/protocol/disco#info'>
	<identity
	category='conference'
	type='text'
	name='Play-Specific Chatrooms'/>
	<identity
	category='directory'
	type='chatroom'
	name='Play-Specific Chatrooms'/>
	<feature var='http://jabber.org/protocol/disco#info'/>
	<feature var='http://jabber.org/protocol/disco#items'/>
	<feature var='http://jabber.org/protocol/muc'/>
	<feature var='jabber:iq:register'/>
	<feature var='jabber:iq:search'/>
	<feature var='jabber:iq:time'/>
	<feature var='jabber:iq:version'/>
	</query>
	</iq>
	*/

	/// <summary>
	/// Summary description for DiscoIdentity.
	/// </summary>
	public class DiscoIdentity : Element
	{
		public DiscoIdentity()
		{
			this.TagName	= "identity";
			this.Namespace	= Uri.DISCO_INFO;
		}

        public DiscoIdentity(string type, string name, string category) : this()
        {
            Type        = type;
            Name        = name;
            Category    = category;
        }

        public DiscoIdentity(string type, string category) : this()
        {
            Type = type;
            Category = category;
        }

        /// <summary>
        /// type name for the entity
        /// </summary>
		public string Type
		{
			get { return GetAttribute("type"); }
			set { SetAttribute("type", value); }
		}

        /// <summary>
        /// natural-language name for the entity
        /// </summary>
		public string Name
		{
			get { return GetAttribute("name"); }
			set { SetAttribute("name", value); }
		}
		
        /// <summary>
        /// category name for the entity
        /// </summary>
		public string Category
		{
			get { return GetAttribute("category"); }
			set { SetAttribute("category", value); }
		}

		
	}
}
