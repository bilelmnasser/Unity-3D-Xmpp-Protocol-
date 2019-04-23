
#region Using directives

using System;

#endregion

namespace Xmpp.protocol.component
{
    /// <summary>
    /// Summary description for Presence.
    /// </summary>
    public class Presence : Xmpp.protocol.client.Presence
    {
        #region << Constructors >>
        public Presence() : base()
        {
            this.Namespace = Uri.ACCEPT;
        }

        public Presence(Xmpp.protocol.client.ShowType show, string status) : this()
        {
            this.Show = show;
            this.Status = status;
        }

        public Presence(Xmpp.protocol.client.ShowType show, string status, int priority) : this(show, status)
        {
            this.Priority = priority;
        }
        #endregion

        /// <summary>
        /// Error Child Element
        /// </summary>
        public new Xmpp.protocol.component.Error Error
        {
            get
            {
                return SelectSingleElement(typeof(Xmpp.protocol.component.Error)) as Xmpp.protocol.component.Error;

            }
            set
            {
                if (HasTag(typeof(Xmpp.protocol.component.Error)))
                    RemoveTag(typeof(Xmpp.protocol.component.Error));

                if (value != null)
                    this.AddChild(value);
            }
        }
    }
}
