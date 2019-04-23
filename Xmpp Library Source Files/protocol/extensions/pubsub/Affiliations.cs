using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.pubsub
{
    /*
        <iq type='result'
            from='pubsub.shakespeare.lit'
            to='francisco@denmark.lit'
            id='affil1'>
          <pubsub xmlns='http://jabber.org/protocol/pubsub'>
            <affiliations>
              <affiliation node='node1' jid='francisco@denmark.lit' affiliation='owner'/>
              <affiliation node='node2' jid='francisco@denmark.lit' affiliation='publisher'/>
              <affiliation node='node5' jid='francisco@denmark.lit' affiliation='outcast'/>
              <affiliation node='node6' jid='francisco@denmark.lit' affiliation='owner'/>
            </affiliations>
          </pubsub>
        </iq>
    */

    public class Affiliations : Element
    {
        #region << Consrtuctors >>
        public Affiliations()
        {
            this.TagName    = "affiliations";
            this.Namespace  = Uri.PUBSUB;
        }
        #endregion

        public Affiliation AddAffiliation()
        {
            Affiliation aff = new Affiliation();
            AddChild(aff);
            return aff;
        }


        public Affiliation AddAffiliation(Affiliation aff)
        {
            AddChild(aff);
            return aff;
        }

        public Affiliation[] GetAffiliations()
        {
            ElementList nl = SelectElements(typeof(Affiliation));
            Affiliation[] items = new Affiliation[nl.Count];
            int i = 0;
            foreach (Element e in nl)
            {
                items[i] = (Affiliation) e;
                i++;
            }
            return items;
        }
    }
}
