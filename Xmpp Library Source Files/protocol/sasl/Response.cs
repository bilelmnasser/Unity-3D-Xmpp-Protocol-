using System;

using Xmpp.Xml.Dom;

//<response xmlns='urn:ietf:params:xml:ns:xmpp-sasl'>
//dXNlcm5hbWU9InNvbWVub2RlIixyZWFsbT0ic29tZXJlYWxtIixub25jZT0i
//T0E2TUc5dEVRR20yaGgiLGNub25jZT0iT0E2TUhYaDZWcVRyUmsiLG5jPTAw
//MDAwMDAxLHFvcD1hdXRoLGRpZ2VzdC11cmk9InhtcHAvZXhhbXBsZS5jb20i
//LHJlc3BvbnNlPWQzODhkYWQ5MGQ0YmJkNzYwYTE1MjMyMWYyMTQzYWY3LGNo
//YXJzZXQ9dXRmLTgK
//</response>
namespace Xmpp.protocol.sasl
{
	/// <summary>
	/// Summary description for Response.
	/// </summary>
	public class Response : Element
	{
		public Response()
		{
			TagName	= "response";
			Namespace	= Uri.SASL;
		}

		public Response(string text) 
            : this()
		{
			TextBase64	= text;
		}

        //public Response(byte[] bytes)
        //    : this()
        //{
        //    this.Value = Convert.ToBase64String(bytes);
        //}
	}
}