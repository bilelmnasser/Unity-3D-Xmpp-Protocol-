using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.vcard
{
	/// <summary>
	/// 
	/// </summary>
	public class Name : Element
	{
		// <N>
		//	<FAMILY>Saint-Andre<FAMILY>
		//	<GIVEN>Peter</GIVEN>
		//	<MIDDLE/>
		// </N>
		#region << Constructors >>
		public Name()
		{
			this.TagName	= "N";
			this.Namespace	= Uri.VCARD;
		}
		public Name(string family, string given, string middle) : this()
		{
			this.Family	= family;
			this.Given	= given;
			this.Middle	= middle;
		}
		#endregion
		
		public string Family
		{
			get { return GetTag("FAMILY"); }
			set { SetTag("FAMILY", value); }
		}

		public string Given
		{
			get { return GetTag("GIVEN"); }
			set { SetTag("GIVEN", value); }

		}
		public string Middle
		{
			get { return GetTag("MIDDLE"); }
			set { SetTag("MIDDLE", value); }
		}
	}
}
