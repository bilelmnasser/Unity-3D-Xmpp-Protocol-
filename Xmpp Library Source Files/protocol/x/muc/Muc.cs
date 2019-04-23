using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.x.muc
{
    /*
     
        <x xmlns='http://jabber.org/protocol/muc'>
            <password>secret</password>
        </x>
     
     */
      
    /// <summary>
    /// Summary description for MucUser.
    /// </summary>
    public class Muc : Element
    {
        #region << Constructor >>
        public Muc()
        {
            this.TagName    = "x";
            this.Namespace  = Uri.MUC;
        }
        #endregion

        public string Password
		{
			set	{ SetTag("password", value); }
			get { return GetTag("password"); }
		}

        /// <summary>
        /// The History object
        /// </summary>
        public History History
        {
            get
            {
                return SelectSingleElement(typeof(History)) as History;
            }
            set
            {
                if (HasTag(typeof(History)))
                    RemoveTag(typeof(History));

                if (value != null)
                    this.AddChild(value);
            }
        }
    }
}  