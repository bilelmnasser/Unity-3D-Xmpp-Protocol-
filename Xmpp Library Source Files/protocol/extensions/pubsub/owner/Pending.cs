using System;

using Xmpp.protocol.x.data;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.pubsub.owner
{
    public class Pending : Element
    {
        #region << Constructors >>
        public Pending() 
        {            
            this.TagName = "pending";
            this.Namespace = Uri.PUBSUB_OWNER;
        }

        public Pending(string node) : this()
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
        /// The x-Data Element
        /// </summary>
        public Data Data
        {
            get
            {
                return SelectSingleElement(typeof(Data)) as Data;

            }
            set
            {
                if (HasTag(typeof(Data)))
                    RemoveTag(typeof(Data));

                if (value != null)
                    this.AddChild(value);
            }
        }
    }
}
