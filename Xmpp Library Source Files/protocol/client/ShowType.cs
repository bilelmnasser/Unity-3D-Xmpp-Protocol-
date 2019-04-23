
using System;

namespace Xmpp.protocol.client
{
	//	# away -- The entity or resource is temporarily away.
	//	# chat -- The entity or resource is actively interested in chatting.
	//	# dnd -- The entity or resource is busy (dnd = "Do Not Disturb").
	//	# xa -- The entity or resource is away for an extended period (xa = "eXtended Away").
	
	/// <summary>
	/// Enumeration that represents the online state.
	/// </summary>
	public enum ShowType
	{
		/// <summary>
		/// 
		/// </summary>
		NONE = -1,
		
		/// <summary>
		/// The entity or resource is temporarily away.
		/// </summary>
		away,
		
		/// <summary>
		/// The entity or resource is actively interested in chatting.
		/// </summary>
		chat,
		
		/// <summary>
		/// The entity or resource is busy (dnd = "Do Not Disturb").
		/// </summary>
		dnd,
		
		/// <summary>
		/// The entity or resource is away for an extended period (xa = "eXtended Away").
		/// </summary>
		xa,
	}
}