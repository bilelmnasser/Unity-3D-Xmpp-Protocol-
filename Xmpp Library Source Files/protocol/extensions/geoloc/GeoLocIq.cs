using System;

using Xmpp.protocol.client;

namespace Xmpp.protocol.extensions.geoloc
{
    /// <summary>
    /// a GeoLoc InfoQuery
    /// </summary>
    public class GeoLocIq : IQ
    {       
        private GeoLoc m_GeoLoc = new GeoLoc();

        public GeoLocIq()
        {
            base.Query = m_GeoLoc;
            this.GenerateId();
        }

        public GeoLocIq(IqType type) : this()
        {
            this.Type = type;
        }

        public GeoLocIq(IqType type, Jid to) : this(type)
        {
            this.To = to;
        }

        public GeoLocIq(IqType type, Jid to, Jid from) : this(type, to)
        {
            this.From = from;
        }

        public new GeoLoc Query
        {
            get
            {
                return m_GeoLoc;
            }
        }
    }   
}