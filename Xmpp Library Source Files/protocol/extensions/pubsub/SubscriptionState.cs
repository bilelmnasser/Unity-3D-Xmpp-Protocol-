using System;
using System.Text;

namespace Xmpp.protocol.extensions.pubsub
{
    /*
    None  	The node MUST NOT send event notifications or payloads to the Entity.
    Pending 	An entity has requested to subscribe to a node and the request has not yet been approved by a node owner. The node MUST NOT send event notifications or payloads to the entity while it is in this state.
    Unconfigured 	An entity has subscribed but its subscription options have not yet been configured. The node MAY send event notifications or payloads to the entity while it is in this state. The service MAY timeout unconfigured subscriptions.
    Subscribed
    */

    public enum SubscriptionState
    {
        /// <summary>
        /// The node MUST NOT send event notifications or payloads to the Entity.
        /// </summary>
        none,
        
        /// <summary>
        /// An entity has requested to subscribe to a node and the request has not yet been approved 
        /// by a node owner. The node MUST NOT send event notifications or payloads to the entity 
        /// while it is in this state.
        /// </summary>
        pending,
        
        /// <summary>
        /// An entity has subscribed but its subscription options have not yet been configured. 
        /// The node MAY send event notifications or payloads to the entity while it is in this state. 
        /// The service MAY timeout unconfigured subscriptions.
        /// </summary>
        unconfigured,
        
        /// <summary>
        /// 
        /// </summary>
        subscribed
    }
}
