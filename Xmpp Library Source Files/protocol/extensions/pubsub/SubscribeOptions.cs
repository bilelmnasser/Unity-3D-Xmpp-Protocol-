using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.pubsub
{

    /*
        <xs:element name='subscribe-options'>
            <xs:complexType>
              <xs:sequence>
                <xs:element name='required' type='empty' minOccurs='0'/>
              </xs:sequence>
            </xs:complexType>
        </xs:element>
     
        
        Example 36. Service replies with success and indicates that subscription configuration is required

        <iq type='result'
            from='pubsub.shakespeare.lit'
            to='francisco@denmark.lit/barracks'
            id='sub1'>
          <pubsub xmlns='http://jabber.org/protocol/pubsub'>
            <subscription 
                node='blogs/princely_musings'
                jid='francisco@denmark.lit'
                subscription='unconfigured'>
              <subscribe-options>
                <required/>
              </subscribe-options>
            </subscription>
          </pubsub>
        </iq>           
    
    */

    public class SubscribeOptions : Element
    {
        #region << Constructors >>
        public SubscribeOptions()
        {
            this.TagName    = "subscribe-options";
            this.Namespace  = Uri.PUBSUB;
        }

        public SubscribeOptions(bool required)
        {
            this.Required = required;
        }
        #endregion

        public bool Required
        {
            get { return HasTag("required"); }
            set 
            {
                if (value)
                    SetTag("required");
                else
                    RemoveTag("required");       
            }
        }

    }
}
