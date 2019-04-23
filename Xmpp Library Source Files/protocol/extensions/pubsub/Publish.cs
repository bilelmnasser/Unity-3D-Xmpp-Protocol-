using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.pubsub
{
    /*
     Example 9. Entity publishes an item with an ItemID of the Payload Type UserTune

        <iq type="set"
            from="pgm@jabber.org"
            to="pubsub.jabber.org"
            id="publish1">
          <pubsub xmlns="http://jabber.org/protocol/pubsub">
            <publish node="generic/pgm-mp3-player">
              <item id="current">
                <tune xmlns="http://jabber.org/protocol/tune">
                  <artist>Ralph Vaughan Williams</artist>
                  <title>Concerto in F for Bass Tuba</title>
                  <source>Golden Brass: The Collector's Edition</source>
                </tune>
              </item>
            </publish>
          </pubsub>
        </iq>
     
    */

    public class Publish : Element
    {
        #region << Constructors >>
        public Publish()
        {
            this.TagName    = "publish";
            this.Namespace  = Uri.PUBSUB;
        }

        /// <summary>
        /// Its recommended to use this constructor because a node is required
        /// </summary>
        /// <param name="node">Node to publish</param>
        public Publish(string node) : this()
        {
            this.Node = node;
        }

        public Publish(string node, Item item) : this(node)
        {
            this.AddItem(item);
        }
        #endregion

        /// <summary>
        /// The node to publish to. This Property is required
        /// </summary>
        public string Node
        {
            get { return GetAttribute("node"); }
            set { SetAttribute("node", value); }
        }

        /// <summary>
        /// Add a payload Item
        /// </summary>
        /// <returns>returns the added Item</returns>
        public Item AddItem()
        {
            Item item = new Item();
            AddChild(item);
            return item;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns>returns the added item</returns>
        public Item AddItem(Item item)
        {
            AddChild(item);
            return item;
        }

        /// <summary>
        /// This will return all payload items. Multiple items are possible, but doe the most implementaions one item 
        /// should be enough
        /// </summary>
        /// <returns>returns an Array of Items</returns>
        public Item[] GetItems()
        {
            ElementList nl = SelectElements(typeof(Item));
            Item[] items = new Item[nl.Count];
            int i = 0;
            foreach (Element e in nl)
            {
                items[i] = (Item)e;
                i++;
            }
            return items;
        }
    }
}
