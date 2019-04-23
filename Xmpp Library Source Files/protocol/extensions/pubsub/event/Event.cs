using System;
using System.Text;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.pubsub.@event
{
    public class Event : Element
    {
        public Event()
        {
            this.TagName    = "event";
            this.Namespace  = Uri.PUBSUB_EVENT;
        }


        public Delete Delete
        {
            get
            {
                return SelectSingleElement(typeof(Delete)) as Delete;

            }
            set
            {
                if (HasTag(typeof(Delete)))
                    RemoveTag(typeof(Delete));

                if (value != null)
                    this.AddChild(value);
            }
        }

        public Purge Purge
        {
            get
            {
                return SelectSingleElement(typeof(Purge)) as Purge;

            }
            set
            {
                if (HasTag(typeof(Purge)))
                    RemoveTag(typeof(Purge));
                
                if (value != null)
                    this.AddChild(value);
            }
        }

        public Items Items
        {
            get
            {
                return SelectSingleElement(typeof(Items)) as Items;
            }
            set
            {
                if (HasTag(typeof(Items)))
                    RemoveTag(typeof(Items));

                if (value != null)
                    this.AddChild(value);
            }
        }
    }
}
