using System;

using Xmpp.protocol.client;

namespace Xmpp.protocol.x.muc.iq.admin
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
    public class AdminIq : IQ
    {
        private Admin m_Admin = new Admin();

        public AdminIq()
        {
            base.Query = m_Admin;
            this.GenerateId();
        }

        public AdminIq(IqType type) : this()
        {
            this.Type = type;
        }

        public AdminIq(IqType type, Jid to) : this(type)
        {
            this.To = to;
        }

        public AdminIq(IqType type, Jid to, Jid from) : this(type, to)
        {
            this.From = from;
        }

        public new Admin Query
        {
            get
            {
                return m_Admin;
            }
        }
    }
}
