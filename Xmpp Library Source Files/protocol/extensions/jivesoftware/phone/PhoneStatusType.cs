using System;
using System.Text;

namespace Xmpp.protocol.extensions.jivesoftware.phone
{
    /// <summary>
    /// Events are sent to the user when their phone is ringing, 
    /// when a call ends, etc. As with presence, 
    /// pubsub should probably be the mechanism used for sending this information, 
    /// but message packets are used to send events for the time being
    /// </summary>
    public enum PhoneStatusType
    {
        RING, 
        DIALED, 
        ON_PHONE,
        HANG_UP
    }
}
