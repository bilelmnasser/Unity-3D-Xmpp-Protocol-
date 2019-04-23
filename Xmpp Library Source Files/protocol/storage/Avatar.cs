using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.storage
{

	//	<iq id='0' type='set' to='user@server'>
	//		<query xmlns='storage:client:avatar'>
	//			<data mimetype='image/jpeg'>
	//			Base64 Encoded Data
	//			</data>
	//		</query>
	//	</iq>

	/// <summary>
	/// Summary description for Avatar.
	/// </summary>
	public class Avatar : Base.Avatar
	{
		public Avatar() : base()
		{
			this.Namespace	= Uri.STORAGE_AVATAR;
		}
	}
}
