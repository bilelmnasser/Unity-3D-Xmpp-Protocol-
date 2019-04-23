using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.pubsub.owner
{
    /*
        <iq type='result'
            from='pubsub.shakespeare.lit'
            to='hamlet@denmark.lit/elsinore'
            id='ent1'>
          <pubsub xmlns='http://jabber.org/protocol/pubsub#owner'>
            <affiliates node='blogs/princely_musings'>
              <affiliate jid='hamlet@denmark.lit' affiliation='owner'/>
              <affiliate jid='polonius@denmark.lit' affiliation='outcast'/>
            </affiliates>
          </pubsub>
        </iq>
     
     
        <xs:element name='affiliates'>
            <xs:complexType>
              <xs:sequence>
                <xs:element ref='affiliate' minOccurs='0' maxOccurs='unbounded'/>
              </xs:sequence>
              <xs:attribute name='node' type='xs:string' use='required'/>
            </xs:complexType>
          </xs:element>
    */

    public class Affiliates : Element
    {
        #region << Constructors >>
        public Affiliates()
        {
            this.TagName    = "affiliates";
            this.Namespace  = Uri.PUBSUB_OWNER;
        }
                
        public Affiliates(string node) : this()
        {
            this.Node = node;
        }
        #endregion

        public string Node
        {
            get { return GetAttribute("node"); }
            set { SetAttribute("node", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Affiliate AddAffiliate()
        {
            Affiliate affiliate = new Affiliate();
            AddChild(affiliate);
            return affiliate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="affiliate"></param>
        /// <returns></returns>
        public Affiliate AddAffiliate(Affiliate affiliate)
        {
            AddChild(affiliate);
            return affiliate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="affiliates"></param>
        public void AddAffiliates(Affiliate[] affiliates)
        {
            foreach (Affiliate affiliate in affiliates)
            {
                AddAffiliate(affiliate);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Affiliate[] GetAffiliates()
        {
            ElementList nl = SelectElements(typeof(Affiliate));
            Affiliate[] affiliates = new Affiliate[nl.Count];
            int i = 0;
            foreach (Element e in nl)
            {
                affiliates[i] = (Affiliate)e;
                i++;
            }
            return affiliates;
        }
    }
}