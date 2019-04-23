using System;
using System.Text;

namespace Xmpp.protocol.x.data
{
    /// <summary>
    /// Used in XData seach.
    /// includes the headers of the search results
    /// </summary>
    public class Item : FieldContainer
    {
       
        #region << Constructors >>
        public Item()
        {
            this.TagName    = "item";
            this.Namespace  = Uri.X_DATA;
        }
        #endregion
    }
}
