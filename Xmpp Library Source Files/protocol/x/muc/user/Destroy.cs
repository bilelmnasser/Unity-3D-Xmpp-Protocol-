using System;

namespace Xmpp.protocol.x.muc.user
{
    public class Destroy : Xmpp.protocol.x.muc.owner.Destroy
    {
        #region << Constructor >>
        public Destroy() : base()
        {
            this.Namespace = Uri.MUC_USER;
        }

        public Destroy(string reason)
            : this()
        {
            Reason = reason;
        }

        public Destroy(Jid altVenue)
            : this()
        {
            AlternateVenue = altVenue;
        }

        public Destroy(string reason, Jid altVenue)
            : this()
        {
            Reason = reason;
            AlternateVenue = altVenue;
        }
        #endregion  
    }
}
