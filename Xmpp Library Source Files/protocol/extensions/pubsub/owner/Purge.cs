using System;

namespace Xmpp.protocol.extensions.pubsub.owner
{
    // Only the Namespace is different to Purge in the Event Namespace
    public class Purge : @event.Purge
    {
        #region << Constructors >>
        public Purge() : base()
        {
            this.Namespace = Uri.PUBSUB_OWNER;
        }

        public Purge(string node) : this()
        {
            this.Node = node;
        }
        #endregion
    }
}