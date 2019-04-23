using System;

using Xmpp.protocol.client;

namespace Xmpp.protocol.iq.time
{
	/// <summary>
	/// Summary description for TimeIq.
	/// </summary>
	public class TimeIq : IQ
	{
		private Time m_Time = new Time();
		
		public TimeIq()
		{		
			base.Query = m_Time;
			this.GenerateId();
		}

		public TimeIq(IqType type) : this()
		{			
			this.Type = type;		
		}

		public TimeIq(IqType type, Jid to) : this(type)
		{
			this.To = to;
		}

		public TimeIq(IqType type, Jid to, Jid from) : this(type, to)
		{
			this.From = from;
		}

		public new Time Query
		{
			get
			{
				return m_Time;
			}
		}
	}
}