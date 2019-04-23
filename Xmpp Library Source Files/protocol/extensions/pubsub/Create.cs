using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.pubsub
{
    public class Create : PubSubAction
    {
        /*
        <iq type="set"
            from="pgm@jabber.org"
            to="pubsub.jabber.org"
            id="create1">
            <pubsub xmlns="http://jabber.org/protocol/pubsub">
                <create node="generic/pgm-mp3-player"/>
                <configure/>
            </pubsub>
        </iq>
         
        ...
            <pubsub xmlns="http://jabber.org/protocol/pubsub">
                <create node="test"
	                    type="collection"/>
            </pubsub>
        ...
        
        */

        #region << Constructors >>
        public Create() : base()
        {
            this.TagName = "create";            
        }

        public Create(string node) : this()
        {
            this.Node = node;
        }

        public Create(Type type) : this()
        {
            this.Type = type;
        }

        public Create(string node, Type type) : this(node)
        {
            this.Type = type;
        }
        #endregion

       
    }
}
