using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.roster
{
	/// <summary>
	/// Extension JEP-0083, delimiter for nested roster groups
	/// </summary>
	public class Delimiter : Element
	{
		/*
		3.1 Querying for the delimiter 
		All compliant clients SHOULD query for an existing delimiter at login.

		Example 1. Querying for the Delimiter
			
		CLIENT:																												 CLIENT:
		<iq type='get'
			 id='1'>
		<query xmlns='jabber:iq:private'>
			 <roster xmlns='roster:delimiter'/>
				  </query>
		</iq>

		SERVER:
		<iq type='result'
			 id='1'
		from='bill@shakespeare.lit/Globe'
		to='bill@shakespeare.lit/Globe'>
		<query xmlns='jabber:iq:private'>
			 <roster xmlns='roster:delimiter'>::</roster>
		</query>
		</iq>
		*/
		public Delimiter()
		{
			this.TagName	= "roster";
            this.Namespace	= Uri.ROSTER_DELIMITER;
		}

		public Delimiter(string delimiter) : this()
		{
			this.Value = delimiter;
		}

	}
}
