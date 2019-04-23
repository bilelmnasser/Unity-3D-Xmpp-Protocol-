using System;

using Xmpp.protocol.Base;

using Xmpp.Xml;
using Xmpp.Xml.Dom;

namespace Xmpp.protocol.component
{
	public enum RouteType
	{
		NONE = -1,
		error,
		auth,
		session
	}

	/// <summary>
	/// 
	/// </summary>
	public class Route : Stanza
	{
		public Route()
		{
			this.TagName	= "route";
			this.Namespace	= Uri.ACCEPT;	
		}

		public Route(Element route) : this()
		{
			RouteElement = route;
		}

		public Route(Element route, Jid from, Jid to) : this()
		{
			RouteElement	= route;
			From			= from;
			To				= to;
		}

		public Route(Element route, Jid from, Jid to, RouteType type) : this()
		{
			RouteElement	= route;
			From			= from;
			To				= to;
			Type			= type;
		}

		/// <summary>
		/// Gets or Sets the logtype
		/// </summary>
		public RouteType Type
		{
			get 
			{ 
				return (RouteType) GetAttributeEnum("type", typeof(RouteType));
			}
			set 
			{ 
				if (value == RouteType.NONE)
					RemoveAttribute("type");
				else
					SetAttribute("type", value.ToString()); 
			}
		}

		/// <summary>
		/// sets or gets the element to route
		/// </summary>
		public Element RouteElement
		{
			get { return this.FirstChild as Element; }
			set 
			{
				if (this.HasChildElements)
					this.RemoveAllChildNodes();
                
                if (value != null)
				    this.AddChild(value);					
			}
		}
	}
}