using System;

namespace Xmpp.protocol.x.muc
{
	/// <summary>
	/// There are five defined affiliations that a user may have in relation to a room
	/// </summary>
	public enum Affiliation
	{
		/// <summary>
		/// the absence of an affiliation
		/// </summary>
		none,
		owner,
		admin,
		member,
		outcast
	}
}
