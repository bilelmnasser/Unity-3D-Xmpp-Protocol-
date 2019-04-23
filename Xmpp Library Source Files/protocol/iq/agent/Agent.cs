using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.agent
{
	//	<agent jid="conference.myjabber.net"><name>Public Conferencing</name><service>public</service></agent>
	//	<agent jid="aim.myjabber.net"><name>AIM Transport</name><service>aim</service><transport>Enter ID</transport><register/></agent>
	//	<agent jid="yahoo.myjabber.net"><name>Yahoo! Transport</name><service>yahoo</service><transport>Enter ID</transport><register/></agent>
	//	<agent jid="icq.myjabber.net"><name>ICQ Transport</name><service>icq</service><transport>Enter ID</transport><register/></agent>
	//	<agent jid="msn.myjabber.net"><name>MSN Transport</name><service>msn</service><transport>Enter ID</transport><register/></agent>

	/// <summary>
	/// Zusammenfassung für Agent.
	/// </summary>
	public class Agent : Element
	{
		public Agent()
		{
			this.TagName	= "agent";
			this.Namespace	= Uri.IQ_AGENTS;
		}

		public Jid Jid
		{
			get	{ return new Jid(this.GetAttribute("jid"));	}
			set { SetAttribute("jid", value.ToString());	}
		}

		public string Name
		{
			get	{ return GetTag("name"); }
			set { SetTag("name", value); }
		}

		public string Service
		{
			get { return GetTag("service");	}
			set { SetTag("service", value); }
		}

		public string Description
		{
			get { return GetTag("description"); }
			set { SetTag("description", value); }

		}

		/// <summary>
		/// Can we register this agent/transport
		/// </summary>
		public bool CanRegister
		{
			get	{ return HasTag("register"); }
			set
			{
				if (value == true)
					SetTag("register");
				else
					RemoveTag("register");
			}
		}

		/// <summary>
		/// Can we search thru this agent/transport
		/// </summary>
		public bool CanSearch
		{
			get	{ return HasTag("search"); }
			set
			{
				if (value == true)
					SetTag("search");
				else
					RemoveTag("search");
			}
		}
		
		/// <summary>
		/// Is this agent a transport?
		/// </summary>
		public bool IsTransport
		{
			get	{ return HasTag("transport"); }
			set
			{
				if (value == true)
					SetTag("transport");
				else
					RemoveTag("transport");
			}
		}
		
		/// <summary>
		/// Is this agent for groupchat
		/// </summary>
		public bool IsGroupchat
		{
			get	{ return HasTag("groupchat"); }
			set
			{
				if (value == true)
					SetTag("groupchat");
				else
					RemoveTag("groupchat");
			}
		}

	}
}
