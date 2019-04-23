using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.chatstates
{
    /// <summary>
    /// User has effectively ended their participation in the chat session.
    /// User has not interacted with the chat interface, system, or device for a relatively long period of time 
    /// (e.g., 2 minutes), or has terminated the chat interface (e.g., by closing the chat window).
    /// </summary>
    public class Gone : Element
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Gone"/> class.
        /// </summary>
        public Gone()
        {
            TagName    = Chatstate.gone.ToString();
            Namespace  = Uri.CHATSTATES;
        }
    }
}