using System;
using System.Text;

using Xmpp.Xml.Dom;
using Xmpp.protocol.extensions.compression;

namespace Xmpp.protocol.stream.feature.compression
{
    public class Compression : Element
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

        public Compression()
        {
            this.TagName    = "compression";
            this.Namespace  = Uri.FEATURE_COMPRESS;
        }

        /// <summary>
        /// method/algorithm used to compressing the stream
        /// </summary>
        public CompressionMethod Method
        {
            set
            {
                if (value != CompressionMethod.Unknown)
                    SetTag("method", value.ToString());
            }
            get
            {
                return (CompressionMethod) GetTagEnum("method", typeof(CompressionMethod));
            }
        }

        /// <summary>
        /// Add a compression method/algorithm
        /// </summary>
        /// <param name="method"></param>
        public void AddMethod(CompressionMethod method)
        {
            if (!SupportsMethod(method))
                AddChild(new Method(method));
        }

        /// <summary>
        /// Is the given compression method/algrithm supported?
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public bool SupportsMethod(CompressionMethod method)
        {
            ElementList nList = SelectElements(typeof(Method));
            foreach (Method m in nList)
            {
                if (m.CompressionMethod == method)
                    return true;
            }
            return false;
        }

        public Method[] GetMethods()
        {
            ElementList methods = SelectElements(typeof(Method));

            Method[] items = new Method[methods.Count];
            int i = 0;
            foreach (Method m in methods)
            {
                items[i] = m;
                i++;
            }
            return items;
        }
      
    }
}
