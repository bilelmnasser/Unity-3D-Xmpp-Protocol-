using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.bookmarks
{
    /// <summary>
    /// URLs are fairly simple, as they only need to store a URL and a title, 
    /// and the client then can simply launch the appropriate browser.
    /// </summary>
    public class Url : Element
    {
        /*
            <url name='Complete Works of Shakespeare'
         url='http://the-tech.mit.edu/Shakespeare/'/>
        */
        public Url()
        {
            this.TagName    = "url";
            this.Namespace  = Uri.STORAGE_BOOKMARKS;   
        }

        public Url(string address, string name) : this()
        {
            Address = address;
            Name    = name;
        }

        /// <summary>
        /// A description/name for this bookmark
        /// </summary>
        public string Name
        {
            get { return GetAttribute("name"); }
            set { SetAttribute("name", value); }
        }

        /// <summary>
        /// The url address to store e.g. http://www.ag-software,de/
        /// </summary>
        public string Address
        {
            get { return GetAttribute("url"); }
            set { SetAttribute("url", value); }
        }
    }
}
