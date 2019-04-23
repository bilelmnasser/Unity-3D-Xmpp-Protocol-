using System;
using System.Text;

namespace Xmpp.protocol.iq.privacy
{
    /// <summary>
    /// The default list
    /// </summary>
    public class Default : List
    {
        public Default()
        {
            this.TagName = "default";
        }

        public Default(string name) : this()
        {
            Name = name;
        }
    }
}
