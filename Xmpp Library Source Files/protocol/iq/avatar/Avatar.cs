using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.avatar
{
	//	<iq id='2' type='result' to='user@server/resource'>
	//		<query xmlns='jabber:iq:avatar'>
	//			<data mimetype='image/jpeg'>
	//			Base64-Encoded Data
	//			</data>
	//		</query>
	//	</iq>

	/// <summary>
	/// Summary description for Avatar.
	/// </summary>
	public class Avatar : Xmpp.protocol.Base.Avatar
	{
		public Avatar() : base()
		{
			this.Namespace	= Uri.IQ_AVATAR;			
		}	
	}
}
