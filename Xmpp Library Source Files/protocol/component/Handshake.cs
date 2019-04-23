using System;

using Xmpp.protocol.Base;

using Xmpp.Xml;
using Xmpp.Xml.Dom;

namespace Xmpp.protocol.component
{
	
	//<handshake>aaee83c26aeeafcbabeabfcbcd50df997e0a2a1e</handshake>

	/// <summary>
	/// Handshake Element
	/// </summary>
	public class Handshake : Stanza
	{
		public Handshake()
		{
			this.TagName	= "handshake";
			this.Namespace	= Uri.ACCEPT;			
		}

		public Handshake(string password, string streamid) : this()
		{
			SetAuth(password, streamid);
		}

		public void SetAuth(string password, string streamId)
		{
			this.Value = Util.Hash.Sha1Hash(streamId + password);
		}

		/// <summary>
		/// Digest (Hash) for authentication
		/// </summary>
		public string Digest
		{
			get { return this.Value; }
			set { this.Value = value; }

		}
	}
}
