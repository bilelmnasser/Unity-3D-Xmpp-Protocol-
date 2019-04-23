using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.vcard
{
	//	<!-- Email address property. Default type is INTERNET. -->
	//	<!ELEMENT EMAIL (
	//	HOME?, 
	//	WORK?, 
	//	INTERNET?, 
	//	PREF?, 
	//	X400?, 
	//	USERID
	//	)>
	public enum EmailType
	{
		NONE = -1,
		HOME,
		WORK,
		INTERNET,
		X400,
	}

	/// <summary>
	/// 
	/// </summary>
	public class Email : Element
	{	
		// <EMAIL><INTERNET/><PREF/><USERID>stpeter@jabber.org</USERID></EMAIL>
		#region << Constructors >>
		public Email()
		{
			this.TagName	= "EMAIL";
			this.Namespace	= Uri.VCARD;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="type">Type of the new Email Adress</param>
		/// <param name="address">Email Adress</param>
		/// <param name="prefered">Is this adressed prefered</param>
		public Email(EmailType type, string userid, bool prefered) : this()
		{
			Type		= type;
			IsPrefered	= prefered;
			UserId		= userid;			
		}
		#endregion

		public EmailType Type
		{
			get { return (EmailType) HasTagEnum(typeof(EmailType)); }
			set 
			{ 
				if (value != EmailType.NONE)
					SetTag(value.ToString()); 
			}

		}
		/// <summary>
		/// Is this the prefered contact adress?
		/// </summary>
		public bool IsPrefered
		{
			get { return HasTag("PREF"); }
			set 
			{
				if (value == true)
					SetTag("PREF");
				else
					RemoveTag("PREF");
			}
		}

		/// <summary>
		/// The email Adress
		/// </summary>
		public string UserId
		{
			get { return GetTag("USERID"); }
			set { SetTag("USERID", value); }
		}
	}
}
