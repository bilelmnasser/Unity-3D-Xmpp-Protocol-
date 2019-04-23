
using System;

namespace Xmpp.Net.Dns
{
	/// <summary>
	/// Thrown when the server delivers a response we are not expecting to hear
	/// </summary>	
	public class InvalidResponseException : SystemException
	{
		public InvalidResponseException()
		{
			// no implementation
		}

		public InvalidResponseException(Exception innerException) :  base(null, innerException) 
		{
			// no implementation
		}

		public InvalidResponseException(string message, Exception innerException) : base (message, innerException)
		{
			// no implementation
		}
        
        //protected InvalidResponseException(SerializationInfo info, StreamingContext context) : base(info, context)
        //{
        //    // no implementation
        //}
	}
}
