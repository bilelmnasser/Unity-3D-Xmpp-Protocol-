
using System;

namespace Xmpp.Net
{
	/// <summary>
	/// Summary description for SocketType.
	/// </summary>
	public enum SocketConnectionType
	{
#if !SL
		/// <summary>
		/// Direct TCP/IP Connection
		/// </summary>
		Direct,
#endif	
		/// <summary>
		/// A HTTP Polling Socket connection (JEP-0025)
		/// </summary>
		HttpPolling,

        /// <summary>
        /// <para>XEP-0124: Bidirectional-streams Over Synchronous HTTP (BOSH)</para>
        /// <para>http://www.xmpp.org/extensions/xep-0124.html</para>
        /// </summary>
        Bosh
	}
}
