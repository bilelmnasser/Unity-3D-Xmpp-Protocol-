using System;

namespace Xmpp.Net
{
	/// <summary>
	/// Summary description for PollingSocketException.
	/// </summary>
	public class PollSocketException : Exception
	{
		public PollSocketException(string msg) : base(msg)
		{			
		}
	}
}
