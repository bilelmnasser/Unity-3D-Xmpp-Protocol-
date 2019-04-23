using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.x.rosterx
{
    /// <summary>
    /// Roster Item Exchange (JEP-0144)
    /// </summary>
	public class RosterX : Element
	{
		/*
		<message from='horatio@denmark.lit' to='hamlet@denmark.lit'>
		<body>Some visitors, m'lord!</body>
		<x xmlns='http://jabber.org/protocol/rosterx'> 
			<item action='add'
				jid='rosencrantz@denmark.lit'
				name='Rosencrantz'>
				<group>Visitors</group>
			</item>
			<item action='add'
				jid='guildenstern@denmark.lit'
				name='Guildenstern'>
				<group>Visitors</group>
			</item>
		</x>
		</message>
		*/

        /// <summary>
        /// Initializes a new instance of the <see cref="RosterX"/> class.
        /// </summary>
		public RosterX()
		{
			this.TagName	= "x";
			this.Namespace	= Uri.X_ROSTERX;
		}


        /// <summary>
        /// Gets the roster.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Adds a roster item.
        /// </summary>
        /// <param name="r">The r.</param>
		public void AddRosterItem(RosterItem r)
		{
			this.ChildNodes.Add(r);
		}
	}
}
