using System;

using Xmpp.protocol.x.data;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.pubsub
{
    public class Configure : PubSubAction
    {
        #region << Constructors >>
        public Configure() : base()
        {
            this.TagName = "configure";
        }

        public Configure(string node) : this()
        {
            this.Node = node;
        }

        public Configure(Type type) : this()
        {
            this.Type = type;            
        }

        public Configure(string node, Type type) : this(node)
        {            
            this.Type = type;
        }
        #endregion

        public Access Access
		{
			get 
			{
                return (Access)GetAttributeEnum("access", typeof(Access)); 
			}
			set 
			{
                if (value == Access.NONE)
                    RemoveAttribute("access");
                else
                    SetAttribute("access", value.ToString()); 
			}
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
