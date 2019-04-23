

using System;

namespace Xmpp.protocol.x.muc
{
	/// <summary>
	/// There are four defined roles that an occupant may have
	/// </summary>
	public enum Role
	{
		/// <summary>
		/// the absence of a role
		/// </summary>
		none,
		moderator,
		participant,
		visitor		
	}
}
