using Xmpp.protocol.client;

namespace Xmpp.protocol.iq.bind
{
	/// <summary>
	/// Summary description for BindIq.
	/// </summary>
	public class BindIq : IQ
	{
		private Bind m_Bind = new Bind();
		
		public BindIq()
		{
			GenerateId();
			AddChild(m_Bind);
		}

		public BindIq(IqType type) : this()
		{			
			Type = type;
		}

		public BindIq(IqType type, string resource) : this(type)
		{			
			m_Bind.Resource = resource;
		}

        public new Bind Query
        {
            get
            {
                return m_Bind;
            }
        }
	}
}
