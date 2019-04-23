using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.x
{
	
	// <x xmlns="jabber:x:avatar"><hash>bbf231f2b7fa1772c2ec5cffa620d3aedb4bd793</hash></x>

	/// <summary>
	/// JEP-0008 avatars
	/// </summary>
	public class Avatar : Element
	{
		public Avatar()
		{
			this.TagName	= "x";
			this.Namespace	= Uri.X_AVATAR;
		}

        public Avatar(string hash) : this()
        {
            Hash = hash;
        }

		public string Hash
		{
			get
			{
				return GetTag("hash");
			}
			set
			{
				SetTag("hash", value);
			}
		}
	}
}
