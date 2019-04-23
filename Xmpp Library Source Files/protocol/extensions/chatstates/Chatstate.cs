using System;
using System.Text;

namespace Xmpp.protocol.extensions.chatstates
{
    /// <summary>
    /// Enumeration of supported Chatstates (JEP-0085)
    /// </summary>
    public enum Chatstate
    {
        /// <summary>
        /// No Chatstate at all
        /// </summary>
        None,
        /// <summary>
        /// Active Chatstate
        /// </summary>
        active,
        /// <summary>
        /// Inactive Chatstate
        /// </summary>
        inactive,
        /// <summary>
        /// Composing Chatstate
        /// </summary>
        composing,
        /// <summary>
        /// Gone Chatstate
        /// </summary>
        gone,
        /// <summary>
        /// Paused Chatstate
        /// </summary>
        paused
    }
}