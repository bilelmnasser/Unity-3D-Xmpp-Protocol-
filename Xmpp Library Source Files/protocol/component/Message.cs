
#region Using directives

using System;

#endregion

namespace Xmpp.protocol.component
{
    /// <summary>
    /// Summary description for Message.
    /// </summary>
    public class Message : Xmpp.protocol.client.Message
    {
        #region << Constructors >>
        public Message()
            : base()
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Message(Jid to)
            : base(to)
        {
            this.Namespace = Uri.ACCEPT;
        }
        
        public Message(Jid to, string body) 
            : base(to, body)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Message(Jid to, Jid from) 
            : base(to, from)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Message(string to, string body) 
            : base(to, body)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Message(Jid to, string body, string subject)
            : base(to, body, subject)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Message(string to, string body, string subject) 
            : base(to, body, subject)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Message(string to, string body, string subject, string thread)
            : base(to, body, subject, thread)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Message(Jid to, string body, string subject, string thread)
            : base(to, body, subject, thread)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Message(string to, Xmpp.protocol.client.MessageType type, string body)
            : base(to, type, body)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Message(Jid to, Xmpp.protocol.client.MessageType type, string body)
            : base(to, type, body)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Message(string to, Xmpp.protocol.client.MessageType type, string body, string subject)
            : base(to, type, body, subject)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Message(Jid to, Xmpp.protocol.client.MessageType type, string body, string subject)
            : base(to, type, body, subject)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Message(string to, Xmpp.protocol.client.MessageType type, string body, string subject, string thread)
            : base(to, type, body, subject, thread)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Message(Jid to, Xmpp.protocol.client.MessageType type, string body, string subject, string thread)
            : base(to, type, body, subject, thread)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Message(Jid to, Jid from, string body)
            : base(to, from, body)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Message(Jid to, Jid from, string body, string subject)
            : base(to, from, body, subject)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Message(Jid to, Jid from, string body, string subject, string thread)
            : base(to, from, body, subject, thread)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Message(Jid to, Jid from, Xmpp.protocol.client.MessageType type, string body)
            : base(to, from, type, body)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Message(Jid to, Jid from, Xmpp.protocol.client.MessageType type, string body, string subject)
            : base(to, from, type, body, subject)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Message(Jid to, Jid from, Xmpp.protocol.client.MessageType type, string body, string subject, string thread)
            : base(to, from, type, body, subject, thread)
        {
            this.Namespace = Uri.ACCEPT;
        }
        #endregion

        /// <summary>
        /// Error Child Element
        /// </summary>
        public new Xmpp.protocol.component.Error Error
        {
            get
            {
                return SelectSingleElement(typeof(Xmpp.protocol.component.Error)) as Xmpp.protocol.component.Error;

            }
            set
            {
                if (HasTag(typeof(Xmpp.protocol.component.Error)))
                    RemoveTag(typeof(Xmpp.protocol.component.Error));

                if (value != null)
                    this.AddChild(value);
            }
        }
    }
}
