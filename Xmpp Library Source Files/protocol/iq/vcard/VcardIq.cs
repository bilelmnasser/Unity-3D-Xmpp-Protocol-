using System;
using Xmpp.protocol.client;

namespace Xmpp.protocol.iq.vcard
{
	//<iq id="id_62" to="gnauck@myjabber.net" type="get"><vCard xmlns="vcard-temp"/></iq>
	
	/// <summary>
	/// Summary description for VcardIq.
	/// </summary>
	public class VcardIq : IQ
	{
		private Vcard m_Vcard = new Vcard();

		#region << Constructors >>
		public VcardIq()
		{
			this.GenerateId();
			this.AddChild(m_Vcard);
		}	

		public VcardIq(IqType type) : this()
		{			
			this.Type = type;		
		}

		public VcardIq(IqType type, Vcard vcard) : this(type)
		{			
			this.Vcard = vcard;
		}

		public VcardIq(IqType type, Jid to) : this(type)
		{
			this.To = to;
		}

		public VcardIq(IqType type, Jid to, Vcard vcard) : this(type, to)
		{
			this.Vcard = vcard;
		}

		public VcardIq(IqType type, Jid to, Jid from) : this(type, to)
		{
			this.From = from;
		}

		public VcardIq(IqType type, Jid to, Jid from, Vcard vcard) : this(type, to, from)
		{
			this.Vcard = vcard;
		}
		#endregion
			
		public override Vcard Vcard 
		{
			get 
			{ 
				return m_Vcard;
			}
			set
			{
				ReplaceChild(value);
			}
		}
	}
}
