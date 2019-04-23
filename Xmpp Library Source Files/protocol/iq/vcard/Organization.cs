using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.vcard
{

	/// <summary>
	/// 
	/// </summary>
	public class Organization : Element
	{
		// <ORG>
		//	<ORGNAME>Jabber Software Foundation</ORGNAME>
		//	<ORGUNIT/>
		// </ORG>

		#region << Constructors >>
		public Organization()
		{
			this.TagName	= "ORG";
			this.Namespace	= Uri.VCARD;
		}
		
		public Organization(string name, string unit) : this()
		{			
			this.Name	= name;		
			this.Unit	= unit;
		}
		#endregion

		public string Name
		{
			get { return GetTag("ORGNAME"); }
			set { SetTag("ORGNAME", value); }
		}

		public string Unit
		{
			get { return GetTag("ORGUNIT"); }
			set { SetTag("ORGUNIT", value); }
		}
	}
}
