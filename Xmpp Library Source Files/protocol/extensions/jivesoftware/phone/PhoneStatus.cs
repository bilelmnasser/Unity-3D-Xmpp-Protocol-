using System;
using System.Text;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.jivesoftware.phone
{
    /// <summary>
    /// A user's presence is updated when on a phone call.
    /// The Jive Messenger/Asterisk implementation will update the user's presence automatically 
    /// by adding the following packet extension to the user's presence:
    /// &lt;phone-status xmlns="http://jivesoftware.com/xmlns/phone" status="ON_PHONE" &gt; 
    /// Jive Messenger can also be configured to change the user's availability
    /// to "Away -- on the phone" when the user is on a call (in addition to the packet extension).
    /// This is useful when interacting with clients that don't understand the extended presence information
    /// or when using transports to other IM networks where extended presence information is not available.        
    /// </summary>
    public class PhoneStatus : Element
    {
        /*
         * <phone-status xmlns="http://jivesoftware.com/xmlns/phone" status="ON_PHONE" >; 
         * 
         */ 
        
        public PhoneStatus()
        {
            this.TagName    = "phone-status";
            this.Namespace  = Uri.JIVESOFTWARE_PHONE;
        }

        public PhoneStatusType Status
        {
            set
            {
                SetAttribute("status", value.ToString());
            }
            get
            {
                return (PhoneStatusType)GetAttributeEnum("status", typeof(PhoneStatusType));
            }
        }
    }
}
