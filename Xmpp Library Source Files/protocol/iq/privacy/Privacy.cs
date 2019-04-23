using System;
using System.Text;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.privacy
{
    public class Privacy : Element
    {
        public Privacy()
        {
            this.TagName    = "query";
            this.Namespace  = Uri.IQ_PRIVACY;
        }
        
        /// <summary>
        /// Add a provacy list
        /// </summary>
        /// <param name="list"></param>
        public void AddList(List list)
        {
            this.AddChild(list);
        }

        /// <summary>
        /// Get all Lists
        /// </summary>
        /// <returns>Array of all privacy lists</returns>
        public List[] GetList()
        {
            ElementList el = SelectElements(typeof(List));
            int i = 0;
            List[] result = new List[el.Count];
            foreach (List list in el)
            {
                result[i] = list;
                i++;
            }
            return result;
        }

        /// <summary>
        /// The active list
        /// </summary>
        public Active Active
        {
            get
            {
                return SelectSingleElement(typeof(Active)) as Active;
            }
            set
            {
                if (HasTag(typeof(Active)))
                    RemoveTag(typeof(Active));

                if (value != null)
                    this.AddChild(value);
            }
        }

        /// <summary>
        /// The default list
        /// </summary>
        public Default Default
        {
            get
            {
                return SelectSingleElement(typeof(Default)) as Default;
            }
            set
            {
                if (HasTag(typeof(Default)))
                    RemoveTag(typeof(Default));

                this.AddChild(value);
            }
        }
    }
}
