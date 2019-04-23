
using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.chatstates
{
    /// <summary>
    /// User had been composing but now has stopped.
    /// User was composing but has not interacted with the message input interface for a short period of time (e.g., 5 seconds).
    /// </summary>
    public class Paused : Element
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Paused"/> class.
        /// </summary>
        public Paused()
        {
            TagName    = Chatstate.paused.ToString();
            Namespace  = Uri.CHATSTATES;
        }
    }
}