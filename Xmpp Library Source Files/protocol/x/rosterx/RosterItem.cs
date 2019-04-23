using System;

using Xmpp.protocol.Base;

namespace Xmpp.protocol.x.rosterx
{
	public enum Action
	{
		NONE = -1,
		add,
		remove,
		modify
	}

	/// <summary>
	/// Summary description for RosterItem.
	/// </summary>
	public class RosterItem : Xmpp.protocol.Base.RosterItem
	{
		/*
		<item action='delete' jid='rosencrantz@denmark' name='Rosencrantz'>   
			<group>Visitors</group>   
		</item> 
		*/

		public RosterItem() : base()
		{
			this.Namespace	= Uri.X_ROSTERX;
		}

		public RosterItem(Jid jid) : this()
		{
			Jid = jid;				
		}

		public RosterItem(Jid jid, string name) : this(jid)
		{
			Name = name;
		}

		public RosterItem(Jid jid, string name, Action action) : this(jid, name)
		{
			Action = action;
		}

		public Action Action
		{
			get 
			{ 
				return (Action) GetAttributeEnum("action", typeof(Action)); 
			}
			set { SetAttribute("action", value.ToString()); }
		}

	}
}
