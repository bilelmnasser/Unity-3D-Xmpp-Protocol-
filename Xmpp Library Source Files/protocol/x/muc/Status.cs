using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.x.muc
{
    /*
    <x xmlns='http://jabber.org/protocol/muc#user'>
        <status code='100'/>
    </x>    
    */

    /// <summary>
    /// Summary description for MucUser.
    /// </summary>
    public class Status : Element
    {
        #region << Constructors >>
        public Status()
        {
            this.TagName    = "status";
            this.Namespace  = Uri.MUC_USER;
        }

        public Status(StatusCode code) : this()
        {
            this.Code = code;
        }

        public Status(int code) : this()
        {
            SetAttribute("code", code);
        }
        #endregion

        public StatusCode Code
		{
			get 
			{
                return (StatusCode)GetAttributeEnum("code", typeof(StatusCode)); 
			}
			set 
			{ 
				SetAttribute("code", value.ToString()); 
			}
		}
    }

}