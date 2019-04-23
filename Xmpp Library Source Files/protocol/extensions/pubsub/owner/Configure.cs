using Xmpp.protocol.x.data;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.pubsub.owner
{
    public class Configure : Element
    {
        #region << Constructor >>
        public Configure()
        {
            TagName    = "configure";
            Namespace  = Uri.PUBSUB_OWNER;
        }

        public Configure(string node) : this()
        {
            Node = node;
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
                    AddChild(value);
            }
        }
    }
}
