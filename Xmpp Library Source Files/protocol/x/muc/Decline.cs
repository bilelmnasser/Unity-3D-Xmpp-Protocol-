using System;
using System.Text;

namespace Xmpp.protocol.x.muc
{
    /*
    Example 45. Invitee Declines Invitation

    <message
        from='hecate@shakespeare.lit/broom'
        to='darkcave@macbeth.shakespeare.lit'>
      <x xmlns='http://jabber.org/protocol/muc#user'>
        <decline to='crone1@shakespeare.lit'>
          <reason>
            Sorry, I'm too busy right now.
          </reason>
        </decline>
      </x>
    </message>
        

    Example 46. Room Informs Invitor that Invitation Was Declined

    <message
        from='darkcave@macbeth.shakespeare.lit'
        to='crone1@shakespeare.lit/desktop'>
      <x xmlns='http://jabber.org/protocol/muc#user'>
        <decline from='hecate@shakespeare.lit'>
          <reason>
            Sorry, I'm too busy right now.
          </reason>
        </decline>
      </x>
    </message>
    */
     
    public class Decline : Invitation
    {
        #region << Constructors >>
        public Decline() : base()
        {
            this.TagName    = "decline";            
        }
        
        public Decline(string reason) : this()
        {
            this.Reason = reason;
        }

        public Decline(Jid to) : this()
        {
            this.To = to;
        }

        public Decline(Jid to, string reason): this()
        {            
            this.To     = to;
            this.Reason = reason;
        }
        #endregion
    }
}
