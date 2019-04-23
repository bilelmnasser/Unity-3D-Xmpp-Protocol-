using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.roster
{

	/// <summary>
	/// Zusammenfassung für Roster.
	/// </summary>
	public class Roster : Element
	{

		// Request Roster:
		// <iq id='someid' to='myjabber.net' type='get'>
		//		<query xmlns='jabber:iq:roster'/>
		// </iq>
		public Roster()
		{
			this.TagName	= "query";
			this.Namespace	= Uri.IQ_ROSTER;
		}

		public RosterItem[] GetRoster()
		{
            ElementList nl = SelectElements(typeof(RosterItem));
			int i = 0;
			RosterItem[] result = new RosterItem[nl.Count];
			foreach (RosterItem ri in nl)
			{				
				result[i] = (RosterItem) ri;
				i++;
			}
			return result;
		}
		
		public void AddRosterItem(RosterItem r)
		{
			this.ChildNodes.Add(r);
		}		
	}
}
