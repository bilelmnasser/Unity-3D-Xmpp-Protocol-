
using System;

namespace Xmpp
{
    /// <summary>
    /// Represents the current state of a XMPPConnection
    /// </summary>
    public enum XmppConnectionState
    {
        /// <summary>
        /// Session is Disconnected
        /// </summary>
        Disconnected,

        /// <summary>
        /// The Socket is Connecting
        /// </summary>
        Connecting,

        /// <summary>
        /// The Socket is Connected
        /// </summary>
        Connected,
        /// <summary>
        /// The XMPP Session is authenticating
        /// </summary>
        Authenticating,
        /// <summary>
        /// The XMPP session is autrhenticated
        /// </summary>
        Authenticated,

        /// <summary>
        /// Resource Binding gets started
        /// </summary>
        Binding,

        /// <summary>
        /// Resource Binded with sucess
        /// </summary>
        Binded,

        StartSession,

        /// <summary>
        /// Initialize Stream Compression
        /// </summary>
        StartCompression,
        
        /// <summary>
        /// Stream is compressed now
        /// </summary>
        Compressed,

        SessionStarted,

        /// <summary>
        /// We are switching from a normal connection to a secure SSL connection (StartTLS)
        /// </summary>
        Securing,

        /// <summary>
        /// started the progress to register a new account
        /// </summary>
        Registering,

        /// <summary>
        /// Account was registered successful
        /// </summary>
        Registered
    }
}
