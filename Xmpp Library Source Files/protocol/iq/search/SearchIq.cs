using System;

using Xmpp.protocol.client;

//	Example 1. Requesting Search Fields
//
//	<iq type='get'
//		from='romeo@montague.net/home'
//		to='characters.shakespeare.lit'
//		id='search1'
//		xml:lang='en'>
//		<query xmlns='jabber:iq:search'/>
//	</iq>

namespace Xmpp.protocol.iq.search
{
	/// <summary>
	/// Summary description for SearchIq.
	/// </summary>
	public class SearchIq : IQ
	{
		private Search m_Search = new Search();

		public SearchIq()
		{
			base.Query = m_Search;
			this.GenerateId();
		}

		public SearchIq(IqType type) : this()
		{			
			this.Type = type;		
		}

		public SearchIq(IqType type, Jid to) : this(type)
		{
			this.To = to;
		}

		public SearchIq(IqType type, Jid to, Jid from) : this(type, to)
		{
			this.From = from;
		}
		
		public new Search Query
		{
			get
			{
				return m_Search;
			}
		}

	}
}
