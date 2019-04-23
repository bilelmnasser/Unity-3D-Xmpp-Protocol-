
using System;

namespace Xmpp.protocol.component
{
    public delegate void MessageHandler     (object sender, Message msg);
    public delegate void PresenceHandler    (object sender, Presence pres);
    public delegate void IqHandler          (object sender, IQ iq);
}
