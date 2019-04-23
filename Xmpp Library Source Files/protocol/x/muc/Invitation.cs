using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.x.muc
{
    /// <summary>
    /// A base class vor Decline and Invite
    /// We need From, To and SwitchDirection here. This is why we inherit from XmppPacket Base
    /// </summary>
    public abstract class Invitation : Base.Stanza
    {
        public Invitation()
        {
            this.Namespace = Uri.MUC_USER;
        }
        
        /// <summary>
        /// A reason why you want to invite this contact
        /// </summary>
        public string Reason
        {
            set { SetTag("reason", value); }
            get { return GetTag("reason"); }
        }
    }
}
