using System;

namespace Xmpp.protocol.client
{
	/// <summary>
	/// Enumeration that represents the type of a message
	/// </summary>
	public enum MessageType
	{	
		/// <summary>
		/// This in a normal message, much like an email. You dont expect a fast
		/// </summary>
		normal = -1, 	
		
		/// <summary>
		/// a error messages
		/// </summary>
		error,
 		
		/// <summary>
		/// is for chat like messages, person to person. Send this if you expect a fast reply. reply or no reply at all.
		/// </summary>
		chat,

		/// <summary>
		/// is used for sending/receiving messages from/to a chatroom (IRC style chats) 
		/// </summary>
		/// 
		groupchat,
		
        /// <summary>
		/// Think of this as a news broadcast, or RRS Feed, the message will normally have a URL and Description Associated with it.
		/// </summary>
		headline
	}	
}