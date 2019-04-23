

using System;

namespace Xmpp.Net.Dns
{
	/// <summary>
	/// Thrown when the server does not respond
	/// </summary>	
	public class NoResponseException : SystemException
	{
		public NoResponseException()
		{
			// no implementation
		}

		public NoResponseException(Exception innerException) :  base(null, innerException) 
		{
			// no implementation
		}

		public NoResponseException(string message, Exception innerException) : base (message, innerException)
		{
			// no implementation
		}
    }
}