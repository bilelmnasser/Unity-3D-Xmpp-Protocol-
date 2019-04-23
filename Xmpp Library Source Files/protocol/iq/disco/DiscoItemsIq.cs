using System;

using Xmpp.protocol;
using Xmpp.protocol.client;

namespace Xmpp.protocol.iq.disco
{
	/*
	Example 10. Requesting all items

	<iq type='get'
	from='romeo@montague.net/orchard'
	to='shakespeare.lit'
	id='items1'>
	<query xmlns='http://jabber.org/protocol/disco#items'/>
	</iq>
	
	
	Example 11. Result-set for all items

	<iq type='result'
		from='shakespeare.lit'
		to='romeo@montague.net/orchard'
		id='items1'>
	<query xmlns='http://jabber.org/protocol/disco#items'>
		<item jid='people.shakespeare.lit'
			name='Directory of Characters'/>
		<item jid='plays.shakespeare.lit'
			name='Play-Specific Chatrooms'/>
		<item jid='mim.shakespeare.lit'
			name='Gateway to Marlowe IM'/>
		<item jid='words.shakespeare.lit'
			name='Shakespearean Lexicon'/>
		<item jid='globe.shakespeare.lit'
			name='Calendar of Performances'/>
		<item jid='headlines.shakespeare.lit'
			name='Latest Shakespearean News'/>
		<item jid='catalog.shakespeare.lit'
			name='Buy Shakespeare Stuff!'/>
		<item jid='en2fr.shakespeare.lit'
			name='French Translation Service'/>
	</query>
	</iq>
      
     */

	/// <summary>
	/// Discovering the Items Associated with a Jabber Entity
	/// </summary>
	public class DiscoItemsIq : IQ
	{
		private DiscoItems m_DiscoItems = new DiscoItems();
	
		public DiscoItemsIq()
		{
			base.Query = m_DiscoItems;
			this.GenerateId();
		}

		public DiscoItemsIq(IqType type) : this()
		{			
			this.Type = type;		
		}	

        public new DiscoItems Query
        {
            get
            {
                return m_DiscoItems;
            }
        }
	}
}