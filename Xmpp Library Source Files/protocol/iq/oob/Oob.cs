using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.oob
{

	
	 //	<iq type="set" to="horatio@denmark" from="sailor@sea" id="i_oob_001">
	 //		<query xmlns="jabber:iq:oob">
	 //			<url>http://denmark/act4/letter-1.html</url>
	 //			<desc>There's a letter for you sir.</desc>
	 //		</query>
	 // </iq>	

	/// <summary>
	/// Zusammenfassung für Oob.
	/// </summary>
	public class Oob : Element
	{
		public Oob()
		{
			this.TagName	= "query";
			this.Namespace	= Uri.IQ_OOB;
		}

		public string Url
		{
			set
			{
				SetTag("url", value);
			}
			get
			{
				return GetTag("url");
			}
		}
		
		public string Description
		{
			set
			{
				SetTag("desc", value);
			}
			get
			{
				return GetTag("desc");
			}

		}
	}
}
