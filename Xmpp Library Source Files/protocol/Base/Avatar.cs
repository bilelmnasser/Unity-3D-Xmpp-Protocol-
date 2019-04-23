using System;
using Xmpp.Xml.Dom;

namespace Xmpp.protocol.Base
{
	// Avatar is in multiple Namespaces. So better to work with a Base class

	/// <summary>
	/// Summary description for Avatar.
	/// </summary>
	public class Avatar : Element
	{		
		public Avatar()
		{
			this.TagName	= "query";				
		}

		public byte[] Data
		{
			get
			{
				if ( HasTag("data") )
					return Convert.FromBase64String(GetTag("data"));
				else
					return null;
			}
			set
			{
				SetTag("data", Convert.ToBase64String(value, 0, value.Length));
			}
		}

		public string MimeType
		{
			get
			{
				Element data = SelectSingleElement("data");
				if (data != null)
					return GetAttribute("mimetype");
				else
					return null;
			}
			set
			{
				Element data = SelectSingleElement("data");
				if (data != null)
					SetAttribute("mimetype", value);
			}
		}
	}
	
}
