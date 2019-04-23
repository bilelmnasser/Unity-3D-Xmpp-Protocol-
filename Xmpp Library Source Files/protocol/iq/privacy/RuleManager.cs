using Xmpp.protocol.iq.roster;

namespace Xmpp.protocol.iq.privacy
{
    /// <summary>
    /// Helper class for creating rules for communication blocking
    /// </summary>
    public class RuleManager
    {
        /// <summary>
        /// Block stanzas by Jid
        /// </summary>
        /// <param name="jidToBlock"></param>
        /// <param name="order"></param>
        /// <param name="stanza">stanzas you want to block</param>
        /// <returns></returns>
        public Item BlockByJid(Jid jidToBlock, int order, Stanza stanza)
        {
            return new Item(Action.deny, order, Type.jid, jidToBlock.ToString(), stanza);
        }
                

        /// <summary>
        /// Block stanzas for a given roster group
        /// </summary>
        /// <param name="group"></param>
        /// <param name="order"></param>
        /// <param name="stanza">stanzas you want to block</param>
        /// <returns></returns>
        public Item BlockByGroup(string group, int order, Stanza stanza)
        {
            return new Item(Action.deny, order, Type.group, group, stanza);
        }
                
        /// <summary>
        /// Block stanzas by subscription type
        /// </summary>
        /// <param name="subType"></param>
        /// <param name="order"></param>
        /// <param name="stanza">stanzas you want to block</param>
        /// <returns></returns>
        public Item BlockBySubscription(SubscriptionType subType, int order, Stanza stanza)
        {
            return new Item(Action.deny, order, Type.subscription, subType.ToString(), stanza);
        }

        /// <summary>
        /// Block globally (all users) the given stanzas
        /// </summary>
        /// <param name="order"></param>
        /// <param name="stanza">stanzas you want to block</param>
        /// <returns></returns>
        public Item BlockGlobal(int order, Stanza stanza)
        {
            return new Item(Action.deny, order, stanza);
        }

        /// <summary>
        /// Allow stanzas by Jid
        /// </summary>
        /// <param name="jidToBlock"></param>
        /// <param name="order"></param>
        /// <param name="stanza">stanzas you want to block</param>
        /// <returns></returns>
        public Item AllowByJid(Jid jidToBlock, int order, Stanza stanza)
        {
            return new Item(Action.allow, order, Type.jid, jidToBlock.ToString(), stanza);
        }

        /// <summary>
        /// Allow stanzas for a given roster group
        /// </summary>
        /// <param name="group"></param>
        /// <param name="order"></param>
        /// <param name="stanza">stanzas you want to block</param>
        /// <returns></returns>
        public Item AllowByGroup(string group, int order, Stanza stanza)
        {
            return new Item(Action.allow, order, Type.group, group, stanza);
        }

        /// <summary>
        /// Allow stanzas by subscription type
        /// </summary>
        /// <param name="subType"></param>
        /// <param name="order"></param>
        /// <param name="stanza">stanzas you want to block</param>
        /// <returns></returns>
        public Item AllowBySubscription(SubscriptionType subType, int order, Stanza stanza)
        {
            return new Item(Action.allow, order, Type.subscription, subType.ToString(), stanza);
        }
        
    }
}
