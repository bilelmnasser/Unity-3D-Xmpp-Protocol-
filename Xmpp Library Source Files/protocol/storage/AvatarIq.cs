using System;
using Xmpp.protocol.client;

namespace Xmpp.protocol.storage
{

	//	Once such data has been set, the avatar can be retrieved by any requesting client from the avatar-generating client's public XML storage:
	//
	//	Example 8.
	//
	//	<iq id='1' type='get' to='user@server'>
	//		<query xmlns='storage:client:avatar'/>
	//	</iq>  

	/// <summary>
	/// Summary description for AvatarIq.
	/// </summary>
	public class AvatarIq : IQ
	{
		private Avatar m_Avatar = new Avatar();

		public AvatarIq()
		{			
			base.Query = m_Avatar;
			this.GenerateId();
		}

		public AvatarIq(IqType type) : this()
		{			
			this.Type = type;		
		}

		public AvatarIq(IqType type, Jid to) : this(type)
		{
			this.To = to;
		}

		public AvatarIq(IqType type, Jid to, Jid from) : this(type, to)
		{
			this.From = from;
		}

		public new Avatar Query
		{
			get
			{
				return m_Avatar;
			}
		}		
	}
}
