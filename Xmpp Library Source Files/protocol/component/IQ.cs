#region Using directives

using System;

#endregion

namespace Xmpp.protocol.component
{
    /// <summary>
    /// Summary description for Iq.
    /// </summary>
    public class IQ : Xmpp.protocol.client.IQ
    {
        #region << Constructors >>
        public IQ() : base()
        {
            this.Namespace = Uri.ACCEPT;
        }

        public IQ(Xmpp.protocol.client.IqType type) : base(type)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public IQ(Jid from, Jid to) : base(from, to)
        {
            this.Namespace = Uri.ACCEPT;
        }

        public IQ(Xmpp.protocol.client.IqType type, Jid from, Jid to) : base(type, from, to)
        {
            this.Namespace = Uri.ACCEPT;
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
