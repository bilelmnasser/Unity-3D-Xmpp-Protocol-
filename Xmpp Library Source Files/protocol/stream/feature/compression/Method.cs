using System;
using System.Text;

using Xmpp.Xml.Dom;
using Xmpp.protocol.extensions.compression;

namespace Xmpp.protocol.stream.feature.compression
{
    public class Method : Element
    {
        /*
         *  <compression xmlns='http://jabber.org/features/compress'>
         *      <method>zlib</method>
         *  </compression>
         * 
         * <stream:features>
         *      <starttls xmlns='urn:ietf:params:xml:ns:xmpp-tls'/>
         *      <compression xmlns='http://jabber.org/features/compress'>
         *          <method>zlib</method>
         *          <method>lzw</method>
         *      </compression>
         * </stream:features>
         */
        #region << Constructors >>
        public Method()
        {
            this.TagName    = "method";
            this.Namespace  = Uri.FEATURE_COMPRESS;
        }

        public Method(CompressionMethod method) : this()
        {
            this.Value      = method.ToString();
        }
        #endregion

        public CompressionMethod CompressionMethod
        {
            get
            {
#if CF
				return (CompressionMethod) util.Enum.Parse(typeof(CompressionMethod), this.Value, true);
#else
                return (CompressionMethod) Enum.Parse(typeof(CompressionMethod), this.Value, true);
#endif
            }
            set { this.Value = value.ToString(); }
        }
    }

}