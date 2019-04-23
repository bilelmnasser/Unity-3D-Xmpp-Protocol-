using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.x.muc
{
    /*
     
        <iq from='crone1@shakespeare.lit/desktop'
            id='begone'
            to='heath@macbeth.shakespeare.lit'
            type='set'>
          <query xmlns='http://jabber.org/protocol/muc#owner'>
            <destroy jid='darkcave@macbeth.shakespeare.lit'>
              <reason>Macbeth doth come.</reason>
            </destroy>
          </query>
        </iq>
     
     */

    /// <summary>
    /// 
    /// </summary>
    public class Destroy : Element
    {
        #region << Constructor >>
        public Destroy()
        {
            this.TagName = "destroy";
            this.Namespace = Uri.MUC_OWNER;
        }

        public Destroy(string reason) : this()
        {
            Reason = reason;
        }

        public Destroy(Jid altVenue) : this()
        {
            AlternateVenue = altVenue;
        }

        public Destroy(string reason, Jid altVenue) : this()
        {
            Reason = reason;
            AlternateVenue = altVenue;
        }
        #endregion                     

        
        /// <summary>
        /// Pptional attribute for a alternate venue
        /// </summary>
        public Jid AlternateVenue
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
                if (value != null)
                    this.SetAttribute("jid", value.ToString());
            }
        }
        
        public string Reason
        {
            set { SetTag("reason", value); }
            get { return GetTag("reason"); }
        }

        public string Password
        {
            set { SetTag("password", value); }
            get { return GetTag("password"); }
        }

    }
}