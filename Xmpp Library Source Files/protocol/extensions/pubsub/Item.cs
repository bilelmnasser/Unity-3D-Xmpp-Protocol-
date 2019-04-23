using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.pubsub
{
    /*
      <xs:element name='item'>
        <xs:complexType>
          <xs:sequence minOccurs='0'>
            <xs:any namespace='##other'/>
          </xs:sequence>
          <xs:attribute name='id' type='xs:string' use='optional'/>
        </xs:complexType>
      </xs:element>
    */
    public class Item : Element
    {
        public Item()
        {
            this.TagName    = "item";
            this.Namespace  = Uri.PUBSUB;
        }

        public Item(string id) : this()
        {
            this.Id = id;
        }

        /// <summary>
        /// The optional id
        /// </summary>
        public string Id
        {
            get { return GetAttribute("id"); }
            set { SetAttribute("id", value); }
        }
    }
}