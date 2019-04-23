using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.pubsub
{
    /*
        <affiliation node='node1' jid='francisco@denmark.lit' affiliation='owner'/>
    */
    public class Affiliation : Element
    {
        #region << Constructors >>
        public Affiliation()
        {
            this.TagName = "affiliation";
            this.Namespace = Uri.PUBSUB;
        }

        public Affiliation(Jid jid, AffiliationType affiliation)
        {
            this.Jid                = jid;
            this.AffiliationType    = affiliation;
        }

        public Affiliation(string node, Jid jid, AffiliationType affiliation) : this(jid, affiliation)
        {
            this.Node = node;
        }
        #endregion

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
        
        public string Node
		{
            get { return GetAttribute("node"); }
			set	{ SetAttribute("node", value); }			
		}

        public AffiliationType AffiliationType
		{
			get 
			{
                return (AffiliationType)GetAttributeEnum("affiliation", typeof(AffiliationType)); 
			}
			set 
			{
                SetAttribute("affiliation", value.ToString()); 
			}
		}
    }
}
