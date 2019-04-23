using System;

using Xmpp.Xml.Dom;
using Xmpp.protocol.tls;

using Xmpp.protocol.client;
using Xmpp.protocol.iq.bind;
using Xmpp.protocol.stream.feature;
using Xmpp.protocol.stream.feature.compression;

//</stream:features>
// <stream:features>
//		<mechanisms xmlns='urn:ietf:params:xml:ns:xmpp-sasl'>
//			<mechanism>DIGEST-MD5</mechanism>
//			<mechanism>PLAIN</mechanism>
//		</mechanisms>
// </stream:features>

// <stream:features>
//		<starttls xmlns='urn:ietf:params:xml:ns:xmpp-tls'>
//			<required/>
//		</starttls>
//		<mechanisms xmlns='urn:ietf:params:xml:ns:xmpp-sasl'>
//			<mechanism>DIGEST-MD5</mechanism>
//			<mechanism>PLAIN</mechanism>
//		</mechanisms>
// </stream:features>

namespace Xmpp.protocol.stream
{
	/// <summary>
	/// Summary description for Features.
	/// </summary>
	public class Features : Element
	{
		public Features()
		{
			this.TagName	= "features";
			this.Namespace	= Uri.STREAM;
		}

		public StartTls StartTls
		{
			get
			{
				return SelectSingleElement(typeof(StartTls)) as StartTls;
			}
			set
			{
				if (HasTag(typeof(StartTls)))
					RemoveTag(typeof(StartTls));
                
                if (value != null)
                    this.AddChild(value);
			}
		}
		
		public Bind Bind
		{
			get
			{
				return SelectSingleElement(typeof(Bind)) as Bind;
			}
			set
			{
				if(HasTag(typeof(Bind)))
					RemoveTag(typeof(Bind));
                
                if (value != null)
				    this.AddChild(value);
			}
		}

        // <stream:stream from="beta.soapbox.net" xml:lang="de" id="373af7e9-6107-4729-8cea-e8b8ea05ceea" xmlns="jabber:client" version="1.0" xmlns:stream="http://etherx.jabber.org/streams">
        
        // <stream:features xmlns:stream="http://etherx.jabber.org/streams">
        //      <compression xmlns="http://jabber.org/features/compress"><method>zlib</method></compression>
        //      <starttls xmlns="urn:ietf:params:xml:ns:xmpp-tls" />
        //      <register xmlns="http://jabber.org/features/iq-register" />
        //      <auth xmlns="http://jabber.org/features/iq-auth" />
        //      <mechanisms xmlns="urn:ietf:params:xml:ns:xmpp-sasl">
        //          <mechanism>PLAIN</mechanism>
        //          <mechanism>DIGEST-MD5</mechanism>
        //          <mechanism>ANONYMOUS</mechanism>
        //      </mechanisms>
        // </stream:features>


        public Compression Compression
        {
            get { return SelectSingleElement(typeof(Compression)) as Compression; }
            set
            {
                if (HasTag(typeof(Compression)))
                    RemoveTag(typeof(Compression));

                if (value != null)
                    this.AddChild(value);
            }
        }

        public Register Register
        {
            get
            {
                return SelectSingleElement(typeof(Register)) as Register;
            }
            set
            {
                if (HasTag(typeof(Register)))
                    RemoveTag(typeof(Register));

                if (value != null)
                    this.AddChild(value);
            }
        }

        public sasl.Mechanisms Mechanisms
        {
            get
            {
                return SelectSingleElement(typeof(sasl.Mechanisms)) as sasl.Mechanisms;
            }
            set
            {
                if (HasTag(typeof(sasl.Mechanisms)))
                    RemoveTag(typeof(sasl.Mechanisms));

                if (value != null)
                    this.AddChild(value);
            }
        }

		public bool SupportsBind
		{
			get { return Bind!=null ? true : false; }
		}

		public bool SupportsStartTls
		{
			get
			{				
				return StartTls!=null ? true : false; 
			}
		}

        /// <summary>
        /// Is Stream Compression supported?
        /// </summary>
        public bool SupportsCompression
        {
            get
            {
                return Compression != null ? true : false;
            }
        }

        /// <summary>
        /// Is Registration supported?
        /// </summary>
        public bool SupportsRegistration
        {
            get
            {
                return Register != null ? true : false;
            }
        }

		
	}
}
