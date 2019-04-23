using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.time
{

	/*
     <iq type='get'
        from='romeo@montague.net/orchard'
        to='juliet@capulet.com/balcony'
        id='time_1'>
      <query xmlns='jabber:iq:time'/>
     </iq>

	 <iq type='result'
        from='juliet@capulet.com/balcony'
        to='romeo@montague.net/orchard'
        id='time_1'>
      <query xmlns='jabber:iq:time'>
        <utc>20020910T17:58:35</utc>
        <tz>MDT</tz>
        <display>Tue Sep 10 12:58:35 2002</display>
      </query>
     </iq>
     */
    
     
	/// <summary>
    /// XEP-0090: Entity Time
	/// </summary>
	public class Time : Element
	{
		public Time()
		{
			this.TagName	= "query";
			this.Namespace	= Uri.IQ_TIME;
		}


		public string Utc 
		{
			get 
			{ 
				return GetTag("utc"); 
			}
			set 
			{ 
				SetTag("utc", value);
			}
		}

		/// <summary>
		/// Timezone
		/// </summary>		
		public string Tz
		{			
			get 
			{ 
				return GetTag("tz"); 
			}
			set 
			{ 
				SetTag("tz", value);			
			}
		}

		/// <summary>
		/// Human-readable date/time.
		/// </summary>
		public string Display
		{
			get 
			{ 
				return GetTag("display"); 
			}
			set 
			{ 
				SetTag("display", value);
			}
		}
	}
}