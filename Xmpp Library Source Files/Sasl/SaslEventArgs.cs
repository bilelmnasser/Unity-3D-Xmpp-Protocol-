using System;

using Xmpp.protocol.sasl;
using Xmpp.protocol.stream;

namespace Xmpp.Sasl
{
	public delegate void SaslEventHandler	(object sender, SaslEventArgs args);

	public class SaslEventArgs
	{
		#region << Constructors >>
		public SaslEventArgs()
		{

		}
		
		public SaslEventArgs(Mechanisms mechanisms)
		{
			Mechanisms = mechanisms;
		}
		#endregion

		// by default the library chooses the auth method
		private bool						m_Auto			= true;

	    /// <summary>
		/// Set Auto to true if the library should choose the mechanism
		/// Set it to false for choosing the authentication method yourself
		/// </summary>
		public bool Auto
		{
			get { return m_Auto; }
			set { m_Auto = value; }
		}

	    /// <summary>
	    /// SASL Mechanism for authentication as string
	    /// </summary>
	    public string Mechanism { get; set; }

	    public Mechanisms Mechanisms { get; set; }
        
        /// <summary>
        /// Extra Data for special Sasl mechanisms
        /// </summary>
        public ExtendedData ExtentedData { get; set; }
	}
}