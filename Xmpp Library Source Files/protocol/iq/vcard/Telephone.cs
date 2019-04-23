using System;
using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.vcard
{
	public enum TelephoneLocation
	{
		NONE = -1,
		HOME,
		WORK
	}
	
	public enum TelephoneType
	{		
		NONE = -1,		
		VOICE,
		FAX,
		PAGER,
		MSG,
		CELL,
		VIDEO,
		BBS,
		MODEM,
		ISDN,
		PCS, 
		PREF, 
		NUMBER	
	}

	/// <summary>
	/// Zusammenfassung für Telephone.
	/// </summary>
	public class Telephone : Element
	{
		//	<TEL><VOICE/><WORK/><NUMBER>303-308-3282</NUMBER></TEL>
		//	<TEL><FAX/><WORK/><NUMBER/></TEL>
		//	<TEL><MSG/><WORK/><NUMBER/></TEL>
		
		#region << Constructors >>
		public Telephone()
		{
			this.TagName	= "TEL";
			this.Namespace	= Uri.VCARD;			
		}

		public Telephone(TelephoneLocation loc, TelephoneType type, string number) : this()
		{
			if(loc != TelephoneLocation.NONE)
				this.Location	= loc;
			
			if(type != TelephoneType.NONE)
				this.Type		= type;
			
			this.Number		= number;
		}
		#endregion

		public string Number
		{
			get { return GetTag("NUMBER"); }
			set	{ SetTag("NUMBER", value); }
		}

		public TelephoneLocation Location
		{
			get
			{
				return (TelephoneLocation) HasTagEnum(typeof(TelephoneLocation));
			}
			set
			{
				SetTag(value.ToString());
			}
		}

		public TelephoneType Type
		{
			get
			{
				return (TelephoneType) HasTagEnum(typeof(TelephoneType));
			}
			set
			{
				SetTag(value.ToString());
			}
		}

	}
}
