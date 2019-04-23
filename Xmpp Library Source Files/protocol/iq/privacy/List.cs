using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.privacy
{
    public class List : Element
    {
        public List()
        {
            this.TagName    = "list";
            this.Namespace  = Uri.IQ_PRIVACY;
        }

        public List(string name) : this()
        {
            Name = name;
        }

        public string Name
        {
            get { return GetAttribute("name"); }
            set { SetAttribute("name", value); }
        }

        /// <summary>
        /// Gets all Rules (Items) when available
        /// </summary>
        /// <returns></returns>
        public Item[] GetItems()
        {
            ElementList el = SelectElements(typeof(Item));
            int i = 0;
            Item[] result = new Item[el.Count];
            foreach (Item itm in el)
            {
                result[i] = itm;
                i++;
            }
            return result;
        }

        /// <summary>
        /// Adds a rule (item) to the list
        /// </summary>
        /// <param name="itm"></param>
        public void AddItem(Item item)
        {
            this.AddChild(item);
        }

        public void AddItems(Item[] items)
        {
            foreach (Item item in items)
            {
                this.AddChild(item);
            }            
        }

        /// <summary>
        /// Remove all items/rules of this list
        /// </summary>
        public void RemoveAllItems()
        {
            this.RemoveTags(typeof(Item));
        }
    }
}