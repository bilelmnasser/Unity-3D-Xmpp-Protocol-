using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.chatstates
{
    /// <summary>
    /// User has not been actively participating in the chat session.
    /// User has not interacted with the chat interface for an intermediate period of time (e.g., 30 seconds).
    /// </summary>
    public class Inactive : Element
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Inactive"/> class.
        /// </summary>
        public Inactive()
        {
            TagName    = Chatstate.inactive.ToString();
            Namespace  = Uri.CHATSTATES;
        }
    }
}