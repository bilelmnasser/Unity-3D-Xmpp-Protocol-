using System;

using Xmpp.protocol.client;

namespace Xmpp.protocol.x.muc.iq.owner
{
    /*
        Example 72. Moderator Kicks Occupant

        <iq from='fluellen@shakespeare.lit/pda'
            id='kick1'
            to='harfleur@henryv.shakespeare.lit'
            type='set'>
          <query xmlns='http://jabber.org/protocol/muc#admin'>
            <item nick='pistol' role='none'>
              <reason>Avaunt, you cullion!</reason>
            </item>
          </query>
        </iq>
    */

    /// <summary>
    /// 
    /// </summary>
    public class OwnerIq : IQ
    {
        private Owner m_Owner = new Owner();

        public OwnerIq()
        {
            base.Query = m_Owner;
            this.GenerateId();
        }

        public OwnerIq(IqType type) : this()
        {
            this.Type = type;
        }

        public OwnerIq(IqType type, Jid to) : this(type)
        {
            this.To = to;
        }

        public OwnerIq(IqType type, Jid to, Jid from) : this(type, to)
        {
            this.From = from;
        }

        public new Owner Query
        {
            get
            {
                return m_Owner;
            }
        }
    }
}
