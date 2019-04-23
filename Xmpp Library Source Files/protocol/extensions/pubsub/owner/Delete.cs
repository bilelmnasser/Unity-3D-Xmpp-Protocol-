using System;

namespace Xmpp.protocol.extensions.pubsub.owner
{
    // Only the Namespace is different to Delete in the event Namespace
    
    public class Delete : @event.Delete
    {
        #region << Constructors >>
        public Delete() : base()    
        {            
            this.Namespace = Uri.PUBSUB_OWNER;
        }

        public Delete(string node)
        {
            this.Node = node;
        }
        #endregion
        
    }
}
