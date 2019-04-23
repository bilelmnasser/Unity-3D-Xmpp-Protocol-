using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.disco
{
	public enum DiscoAction
	{		
		NONE = -1,
		remove,
		update
	}

	/// <summary>
	///
	/// </summary>
	public class DiscoItem : Element
	{
		public DiscoItem()
		{
			this.TagName	= "item";
			this.Namespace	= Uri.DISCO_ITEMS;
		}

		public Jid Jid
		{
			get { return new Jid(GetAttribute("jid")); }
			set { SetAttribute("jid", value.ToString()); }
		}
		
		public string Name
		{
			get { return GetAttribute("name"); }
			set { SetAttribute("name", value); }
		}
		
		public string Node
		{
			get { return GetAttribute("node"); }
			set { SetAttribute("node", value); }
		}

		public DiscoAction Action
		{
			get { return (DiscoAction) GetAttributeEnum("action", typeof(DiscoAction)); }
			set 
			{ 
				if (value == DiscoAction.NONE) 
					RemoveAttribute("action");
				else
					SetAttribute("action", value.ToString()); 
			}
		}
	}
}
