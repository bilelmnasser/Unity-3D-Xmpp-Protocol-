using System;

namespace Xmpp.protocol
{
	/// <summary>
	/// stream:stream Element
	/// This is the first Element we receive from the server.
	/// It encloses our whole xmpp session.
	/// </summary>
	public class Stream : Base.Stream
	{
		public Stream()
		{			
			this.Namespace	= Uri.STREAM;
		}		
	}
}
