

using System;
using System.Text;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.x.data
{
    /// <summary>
    /// Used in XData seach reports.
    /// includes the headers of the search results
    /// </summary>
    public class Reported : FieldContainer
    {
        #region << Constructors >>
        public Reported()
        {
            this.TagName    = "reported";
            this.Namespace  = Uri.X_DATA;            
        }
        #endregion       
    }
}
