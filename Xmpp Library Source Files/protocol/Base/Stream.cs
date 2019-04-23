
using System;

namespace Xmpp.protocol.Base
{
	/// <summary>
	/// Summary description for Stream.
	/// </summary>
	public class Stream : Stanza
	{
		public Stream()
		{
			this.TagName = "stream";
		}

		/// <summary>
		/// The StreamID of the current JabberSession.
		/// Returns null when none available.
		/// </summary>
		public string StreamId
		{
			get
			{				
				return GetAttribute("id");			
			}
			set
			{
				SetAttribute("id", value);
			}
		}

		/// <summary>
		/// See XMPP-Core 4.4.1 "Version Support"
		/// </summary>
		public string Version
		{
			get
			{
				return GetAttribute("version");
			}
			set
			{
				SetAttribute("version", value);
			}
		}
	}
}
