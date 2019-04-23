
using System;

using Xmpp.Xml;
using Xmpp.Xml.Dom;

using Xmpp.protocol.iq;
using Xmpp.protocol.iq.vcard;
using Xmpp.protocol.iq.bind;
using Xmpp.protocol.iq.session;

namespace Xmpp.protocol.client
{
	// a i know that i shouldnt use keywords for Enums. But its much easier this way
	// because of enum.ToString() and enum.Parse() Members
	public enum IqType
	{
		get,
		set,
		result,
		error
	}

	/// <summary>
	/// Iq Stanza.
	/// </summary>
	public class IQ : Base.Stanza
	{        
        #region << Constructors >>
        public IQ()
		{
			this.TagName	= "iq";
			this.Namespace	= Uri.CLIENT;
		}

        public IQ(IqType type) : this()
        {
            this.Type = type;
        }

        public IQ(Jid from, Jid to) : this()
        {
            this.From   = from;
            this.To     = to;
        }

        public IQ(IqType type, Jid from, Jid to) : this()
        {
            this.Type   = type;
            this.From   = from;
            this.To     = to;
        }		
        #endregion

        public IqType Type
		{
			set
			{
				SetAttribute("type", value.ToString());				
			}
			get
			{
				return (IqType) GetAttributeEnum("type", typeof(IqType));
			}
		}

		/// <summary>
		/// The query Element. Value can also be null which removes the Query tag when existing
		/// </summary>
		public Element Query
		{
			get
			{ 				
				return this.SelectSingleElement("query");
			}
			set
			{
				if (value != null)
					ReplaceChild(value);
				else
					RemoveTag("query");				
			}
		}

        /// <summary>
        /// Error Child Element
        /// </summary>
        public Xmpp.protocol.client.Error Error
        {
            get
            {
                return SelectSingleElement(typeof(Xmpp.protocol.client.Error)) as Xmpp.protocol.client.Error;

            }
            set
            {
                // set type automatically to error
                Type = IqType.error;

                if (HasTag(typeof(Xmpp.protocol.client.Error)))
                    RemoveTag(typeof(Xmpp.protocol.client.Error));

                if (value != null)
                    this.AddChild(value);
            }
        }

		/// <summary>
		/// Get or Set the VCard if it is a Vcard IQ
		/// </summary>
		public virtual Vcard Vcard
		{
			get
			{ 				
				return this.SelectSingleElement("vCard") as Vcard;
			}
			set
			{
				if (value != null)
					ReplaceChild(value);
				else
					RemoveTag("vCard");
			}
		}

        /// <summary>
        /// Get or Set the Bind ELement if it is a BingIq
        /// </summary>
        public virtual Bind Bind
        {
            get
            {
                return this.SelectSingleElement(typeof(Bind)) as Bind;
            }
            set
            {
                RemoveTag(typeof(Bind));
                if (value != null)
                    AddChild(value);                
            }
        }


        /// <summary>
        /// Get or Set the Session Element if it is a SessionIq
        /// </summary>
        public virtual Session Session
        {
            get
            {
                return this.SelectSingleElement(typeof(Session)) as Session;
            }
            set
            {
                RemoveTag(typeof(Session));
                if (value != null)
                    AddChild(value);
            }
        }
	}
}
