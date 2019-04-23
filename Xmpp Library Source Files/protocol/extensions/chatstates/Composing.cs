using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.chatstates
{
    /// <summary>
    /// User is composing a message.
    /// User is interacting with a message input interface specific to this chat session 
    /// (e.g., by typing in the input area of a chat window).
    /// </summary>
    public class Composing : Element
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Composing"/> class.
        /// </summary>
        public Composing()
        {
            TagName    = Chatstate.composing.ToString();
            Namespace  = Uri.CHATSTATES;
        }
    }
}