using Xmpp.Xml.Dom;

namespace Xmpp.Sasl
{
	/// <summary>
	/// Summary description for Mechanism.
	/// </summary>
	public abstract class Mechanism
	{
		#region << Properties and member variables >>
        private XmppClientConnection m_XmppClientConnection;                
		private string m_Username;
		private string m_Password;
		private string m_Server;

        public XmppClientConnection XmppClientConnection
        {
            get { return m_XmppClientConnection; }
            set { m_XmppClientConnection = value; }
        }

        /// <summary>
        /// 
        /// </summary>
		public string Username
		{
            // lower case that until i implement our c# port of libIDN
			get { return m_Username; }
			set { m_Username = value != null ? value.ToLower() : null; }
		}
		
        /// <summary>
        /// 
        /// </summary>
		public string Password
		{
			get { return m_Password; }
			set { m_Password = value; }
		}

        /// <summary>
        /// 
        /// </summary>
		public string Server
		{
			get { return m_Server; }
			set { m_Server = value.ToLower(); }
		}

        /// <summary>
        /// Extra data for special Sasl mechanisms
        /// </summary>
        public ExtendedData ExtentedData { get; set; }
		#endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="con"></param>
		public abstract void	Init(XmppClientConnection con);
		
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public abstract void	Parse(Node e);                
	}
}