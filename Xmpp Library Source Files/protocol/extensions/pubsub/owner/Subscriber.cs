using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.pubsub.owner
{
    /*
        <iq type='result'
            from='pubsub.shakespeare.lit'
            to='hamlet@denmark.lit/elsinore'
            id='subman1'>
          <pubsub xmlns='http://jabber.org/protocol/pubsub#owner'>
            <subscribers node='blogs/princely_musings'>
              <subscriber jid='hamlet@denmark.lit' subscription='subscribed'/>
              <subscriber jid='polonius@denmark.lit' subscription='unconfigured'/>
            </subscribers>
          </pubsub>
        </iq>
     
        <xs:element name='subscriber'>
            <xs:complexType>
              <xs:simpleContent>
                <xs:extension base='empty'>
                  <xs:attribute name='subscription' use='required'>
                    <xs:simpleType>
                      <xs:restriction base='xs:NCName'>
                        <xs:enumeration value='none'/>
                        <xs:enumeration value='pending'/>
                        <xs:enumeration value='subscribed'/>
                        <xs:enumeration value='unconfigured'/>
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:attribute>
                  <xs:attribute name='jid' type='xs:string' use='required'/>
                </xs:extension>
              </xs:simpleContent>
            </xs:complexType>
        </xs:element>
    */

    public class Subscriber : Element
    {
        #region << Constructors >>
        public Subscriber()
        {
            this.TagName    = "subscriber";
            this.Namespace  = Uri.PUBSUB_OWNER;
        }

        public Subscriber(Jid jid, SubscriptionState sub) : this()
        {
            this.Jid                = jid;
            this.SubscriptionState   = sub;
        }
        #endregion

        public SubscriptionState SubscriptionState
		{
			get 
			{
                return (SubscriptionState)GetAttributeEnum("subscription", typeof(SubscriptionState)); 
			}
			set 
			{
                SetAttribute("subscription", value.ToString()); 
			}
		}
        
        public Jid Jid
		{
			get 
			{ 
				if (HasAttribute("jid"))
					return new Jid(this.GetAttribute("jid"));
				else
					return null;
			}
			set 
			{ 
				if (value!=null)
					this.SetAttribute("jid", value.ToString());
			}
		}
    }
}
