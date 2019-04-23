using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.chatstates
{
    /// <summary>
    /// User is actively participating in the chat session.
    /// User accepts an initial content message, sends a content message, 
    /// gives focus to the chat interface, or is otherwise paying attention to the conversation.
    /// </summary>
    public class Active : Element
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Active"/> class.
        /// </summary>
        public Active()
        {
            TagName    = Chatstate.active.ToString();
            Namespace  = Uri.CHATSTATES;
        }
    }
}