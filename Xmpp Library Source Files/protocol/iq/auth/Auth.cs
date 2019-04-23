using System;

using Xmpp.Xml;
using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.auth
{
	//	Send:<iq type='get' to='myjabber.net' id='MX_7'>
	//			<query xmlns='jabber:iq:auth'><username>gnauck</username></query>
	//		 </iq>
	//	Recv:<iq type="result" id="MX_7"><query xmlns="jabber:iq:auth"><username>gnauck</username><password/><digest/><resource/></query></iq> 
	//
	//	Send:<iq type='set' id='mx_login'><query xmlns='jabber:iq:auth'><username>gnauck</username><digest>27c05d464e3f908db3b2ca1729674bfddb28daf2</digest><resource>Office</resource></query></iq>
	//	Recv:<iq id="mx_login" type="result"/> 


	/// <summary>
	///
	/// </summary>
	public class Auth : Element
	{
		#region << Constructors >>
		public Auth()
		{
			this.TagName	= "query";
			this.Namespace	= Uri.IQ_AUTH;
		}
		#endregion

		#region << Properties >>
		public string Username
		{
			get	{ return GetTag("username"); }
			set	{ SetTag("username", value); }
		}

		public string Password
		{
			get	{ return GetTag("password"); }
			set	{ SetTag("password", value); }
		}

		public string Resource
		{
			get	{ return GetTag("resource"); }
			set	{ SetTag("resource", value); }
		}

		public string Digest
		{
			get	{ return GetTag("digest"); }
			set { SetTag("digest", value); }			
		}
		#endregion

		#region << Public Methods >>
		/// <summary>
		/// 
		/// </summary>
		/// <param name="username"></param>
		/// <param name="password"></param>
		/// <param name="StreamID"></param>
		public void SetAuthDigest(string username, string password, string StreamID)
		{			
			// Jive Messenger has a problem when we dont remove the password Tag
			this.RemoveTag("password");
			this.Username	= username;
			this.Digest		= Util.Hash.Sha1Hash(StreamID + password);			
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="username"></param>
		/// <param name="password"></param>
		public void SetAuthPlain(string username, string password)
		{			
			// remove digest Tag when existing
			this.RemoveTag("digest");
			this.Username	= username;
			this.Password	= password;
		}
		
		/// <summary>
		/// 
		/// </summary>
		public void SetAuth(string username, string password, string streamId)
		{
			if(HasTag("digest"))
				SetAuthDigest(username, password, streamId);
			else
				SetAuthPlain(username,password);
		}
		#endregion

	}
}