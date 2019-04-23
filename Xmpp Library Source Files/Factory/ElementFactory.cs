using System;
using System.Collections;

using Xmpp.Xml.Dom;

namespace Xmpp.Factory
{
	/// <summary>
	/// Factory class that implements the factory pattern for builing our Elements.
	/// </summary>
	public class ElementFactory
	{		
		/// <summary>
		/// This Hashtable stores Mapping of protocol (tag/namespace) to the Xmpp objects
		/// </summary>
		private static Hashtable m_table = new Hashtable();

		static ElementFactory()
		{
			AddElementType("iq",				Uri.CLIENT,					typeof(Xmpp.protocol.client.IQ));
			AddElementType("message",			Uri.CLIENT,					typeof(Xmpp.protocol.client.Message));
			AddElementType("presence",			Uri.CLIENT,					typeof(Xmpp.protocol.client.Presence));
			AddElementType("error",				Uri.CLIENT,					typeof(Xmpp.protocol.client.Error));
						
			AddElementType("agent",				Uri.IQ_AGENTS,				typeof(Xmpp.protocol.iq.agent.Agent));
			
			AddElementType("item",				Uri.IQ_ROSTER,				typeof(Xmpp.protocol.iq.roster.RosterItem));
			AddElementType("group",				Uri.IQ_ROSTER,				typeof(Xmpp.protocol.Base.Group));
			AddElementType("group",				Uri.X_ROSTERX,				typeof(Xmpp.protocol.Base.Group));

			AddElementType("item",				Uri.IQ_SEARCH,				typeof(Xmpp.protocol.iq.search.SearchItem));			
			
            // Stream stuff
			AddElementType("stream",			Uri.STREAM,					typeof(Xmpp.protocol.Stream));			
            AddElementType("error",				Uri.STREAM,					typeof(Xmpp.protocol.Error));
			
			AddElementType("query",				Uri.IQ_AUTH,				typeof(Xmpp.protocol.iq.auth.Auth));
			AddElementType("query",				Uri.IQ_AGENTS,				typeof(Xmpp.protocol.iq.agent.Agents));
			AddElementType("query",				Uri.IQ_ROSTER,				typeof(Xmpp.protocol.iq.roster.Roster));
			AddElementType("query",				Uri.IQ_LAST,				typeof(Xmpp.protocol.iq.last.Last));
            AddElementType("query",				Uri.IQ_VERSION,				typeof(Xmpp.protocol.iq.version.Version));
			AddElementType("query",				Uri.IQ_TIME,				typeof(Xmpp.protocol.iq.time.Time));
			AddElementType("query",				Uri.IQ_OOB,					typeof(Xmpp.protocol.iq.oob.Oob));
			AddElementType("query",				Uri.IQ_SEARCH,				typeof(Xmpp.protocol.iq.search.Search));
			AddElementType("query",				Uri.IQ_BROWSE,				typeof(Xmpp.protocol.iq.browse.Browse));
			AddElementType("query",				Uri.IQ_AVATAR,				typeof(Xmpp.protocol.iq.avatar.Avatar));
			AddElementType("query",				Uri.IQ_REGISTER,			typeof(Xmpp.protocol.iq.register.Register));
			AddElementType("query",				Uri.IQ_PRIVATE,				typeof(Xmpp.protocol.iq.@private.Private));
            
            // Privacy Lists
            AddElementType("query",             Uri.IQ_PRIVACY,             typeof(Xmpp.protocol.iq.privacy.Privacy));
            AddElementType("item",              Uri.IQ_PRIVACY,             typeof(Xmpp.protocol.iq.privacy.Item));
            AddElementType("list",              Uri.IQ_PRIVACY,             typeof(Xmpp.protocol.iq.privacy.List));
            AddElementType("active",            Uri.IQ_PRIVACY,             typeof(Xmpp.protocol.iq.privacy.Active));
            AddElementType("default",           Uri.IQ_PRIVACY,             typeof(Xmpp.protocol.iq.privacy.Default));
                        
			// Browse
			AddElementType("service",			Uri.IQ_BROWSE,				typeof(Xmpp.protocol.iq.browse.Service));
			AddElementType("item",				Uri.IQ_BROWSE,				typeof(Xmpp.protocol.iq.browse.BrowseItem));

			// Service Discovery			
			AddElementType("query",				Uri.DISCO_ITEMS,			typeof(Xmpp.protocol.iq.disco.DiscoItems));			
			AddElementType("query",				Uri.DISCO_INFO,				typeof(Xmpp.protocol.iq.disco.DiscoInfo));
			AddElementType("feature",			Uri.DISCO_INFO,			    typeof(Xmpp.protocol.iq.disco.DiscoFeature));
			AddElementType("identity",			Uri.DISCO_INFO,			    typeof(Xmpp.protocol.iq.disco.DiscoIdentity));			
			AddElementType("item",				Uri.DISCO_ITEMS,			typeof(Xmpp.protocol.iq.disco.DiscoItem));

			AddElementType("x",					Uri.X_DELAY,				typeof(Xmpp.protocol.x.Delay));
			AddElementType("x",					Uri.X_AVATAR,				typeof(Xmpp.protocol.x.Avatar));
			AddElementType("x",					Uri.X_CONFERENCE,			typeof(Xmpp.protocol.x.Conference));
            AddElementType("x",                 Uri.X_EVENT,                typeof(Xmpp.protocol.x.Event));
			
			//AddElementType("x",					Uri.STORAGE_AVATAR,	typeof(Xmpp.protocol.storage.Avatar));
			AddElementType("query",				Uri.STORAGE_AVATAR,			typeof(Xmpp.protocol.storage.Avatar));

			// XData Stuff
			AddElementType("x",					Uri.X_DATA,					typeof(Xmpp.protocol.x.data.Data));
			AddElementType("field",				Uri.X_DATA,					typeof(Xmpp.protocol.x.data.Field));
			AddElementType("option",			Uri.X_DATA,					typeof(Xmpp.protocol.x.data.Option));
			AddElementType("value",				Uri.X_DATA,					typeof(Xmpp.protocol.x.data.Value));
            AddElementType("reported",          Uri.X_DATA,                 typeof(Xmpp.protocol.x.data.Reported));
            AddElementType("item",              Uri.X_DATA,                 typeof(Xmpp.protocol.x.data.Item));
			
			AddElementType("features",			Uri.STREAM,					typeof(Xmpp.protocol.stream.Features));

			AddElementType("register",			Uri.FEATURE_IQ_REGISTER,	typeof(Xmpp.protocol.stream.feature.Register));
            AddElementType("compression",       Uri.FEATURE_COMPRESS,       typeof(Xmpp.protocol.stream.feature.compression.Compression));
            AddElementType("method",            Uri.FEATURE_COMPRESS,       typeof(Xmpp.protocol.stream.feature.compression.Method));

			AddElementType("bind",				Uri.BIND,					typeof(Xmpp.protocol.iq.bind.Bind));
			AddElementType("session",			Uri.SESSION,				typeof(Xmpp.protocol.iq.session.Session));
			
			// TLS stuff
			AddElementType("failure",			Uri.TLS,					typeof(Xmpp.protocol.tls.Failure));
			AddElementType("proceed",			Uri.TLS,					typeof(Xmpp.protocol.tls.Proceed));
			AddElementType("starttls",			Uri.TLS,					typeof(Xmpp.protocol.tls.StartTls));

			// SASL stuff
			AddElementType("mechanisms",		Uri.SASL,					typeof(Xmpp.protocol.sasl.Mechanisms));
			AddElementType("mechanism",			Uri.SASL,					typeof(Xmpp.protocol.sasl.Mechanism));			
			AddElementType("auth",				Uri.SASL,					typeof(Xmpp.protocol.sasl.Auth));
			AddElementType("response",			Uri.SASL,					typeof(Xmpp.protocol.sasl.Response));
			AddElementType("challenge",			Uri.SASL,					typeof(Xmpp.protocol.sasl.Challenge));
            
            // TODO, this is a dirty hacks for the buggy BOSH Proxy
            // BEGIN
            AddElementType("challenge",         Uri.CLIENT,                 typeof(Xmpp.protocol.sasl.Challenge));
            AddElementType("success",           Uri.CLIENT,                 typeof(Xmpp.protocol.sasl.Success));
            // END

			AddElementType("failure",			Uri.SASL,					typeof(Xmpp.protocol.sasl.Failure));
			AddElementType("abort",				Uri.SASL,					typeof(Xmpp.protocol.sasl.Abort));
			AddElementType("success",			Uri.SASL,					typeof(Xmpp.protocol.sasl.Success));
            
			// Vcard stuff
			AddElementType("vCard",				Uri.VCARD,					typeof(Xmpp.protocol.iq.vcard.Vcard));
            AddElementType("TEL",				Uri.VCARD,					typeof(Xmpp.protocol.iq.vcard.Telephone));
			AddElementType("ORG",				Uri.VCARD,					typeof(Xmpp.protocol.iq.vcard.Organization));
			AddElementType("N",					Uri.VCARD,					typeof(Xmpp.protocol.iq.vcard.Name));
			AddElementType("EMAIL",				Uri.VCARD,					typeof(Xmpp.protocol.iq.vcard.Email));			
			AddElementType("ADR",				Uri.VCARD,					typeof(Xmpp.protocol.iq.vcard.Address));
            // Server stuff
            //AddElementType("stream",            Uri.SERVER,                 typeof(Xmpp.protocol.server.Stream));
            //AddElementType("message",           Uri.SERVER,                 typeof(Xmpp.protocol.server.Message));

			// Component stuff
			AddElementType("handshake",			Uri.ACCEPT,					typeof(Xmpp.protocol.component.Handshake));
			AddElementType("log",				Uri.ACCEPT,					typeof(Xmpp.protocol.component.Log));
			AddElementType("route",				Uri.ACCEPT,					typeof(Xmpp.protocol.component.Route));
			AddElementType("iq",				Uri.ACCEPT,					typeof(Xmpp.protocol.component.IQ));
            AddElementType("message",           Uri.ACCEPT,                 typeof(Xmpp.protocol.component.Message));
            AddElementType("presence",          Uri.ACCEPT,                 typeof(Xmpp.protocol.component.Presence));
            AddElementType("error",             Uri.ACCEPT,                 typeof(Xmpp.protocol.component.Error));

			//Extensions (JEPS)
			AddElementType("header",			Uri.SHIM,					typeof(Xmpp.protocol.extensions.shim.Header));
			AddElementType("headers",			Uri.SHIM,					typeof(Xmpp.protocol.extensions.shim.Headers));
			AddElementType("roster",			Uri.ROSTER_DELIMITER,		typeof(Xmpp.protocol.iq.roster.Delimiter));
			AddElementType("p",					Uri.PRIMARY,				typeof(Xmpp.protocol.extensions.primary.Primary));
            AddElementType("nick",              Uri.NICK,                   typeof(Xmpp.protocol.extensions.nickname.Nickname));

			AddElementType("item",				Uri.X_ROSTERX,				typeof(Xmpp.protocol.x.rosterx.RosterItem));
			AddElementType("x",					Uri.X_ROSTERX,				typeof(Xmpp.protocol.x.rosterx.RosterX));

            // Filetransfer stuff
			AddElementType("file",				Uri.SI_FILE_TRANSFER,		typeof(Xmpp.protocol.extensions.filetransfer.File));
			AddElementType("range",				Uri.SI_FILE_TRANSFER,		typeof(Xmpp.protocol.extensions.filetransfer.Range));

            // FeatureNeg
            AddElementType("feature",           Uri.FEATURE_NEG,            typeof(Xmpp.protocol.extensions.featureneg.FeatureNeg));

            // Bytestreams
            AddElementType("query",             Uri.BYTESTREAMS,            typeof(Xmpp.protocol.extensions.bytestreams.ByteStream));
            AddElementType("streamhost",        Uri.BYTESTREAMS,            typeof(Xmpp.protocol.extensions.bytestreams.StreamHost));
            AddElementType("streamhost-used",   Uri.BYTESTREAMS,            typeof(Xmpp.protocol.extensions.bytestreams.StreamHostUsed));
            AddElementType("activate",          Uri.BYTESTREAMS,            typeof(Xmpp.protocol.extensions.bytestreams.Activate));
            AddElementType("udpsuccess",        Uri.BYTESTREAMS,            typeof(Xmpp.protocol.extensions.bytestreams.UdpSuccess));
            

			AddElementType("si",				Uri.SI,						typeof(Xmpp.protocol.extensions.si.SI));
            
            AddElementType("html",              Uri.XHTML_IM,               typeof(Xmpp.protocol.extensions.html.Html));
            AddElementType("body",              Uri.XHTML,                  typeof(Xmpp.protocol.extensions.html.Body));
            
            AddElementType("compressed",        Uri.COMPRESS,               typeof(Xmpp.protocol.extensions.compression.Compressed));
            AddElementType("compress",          Uri.COMPRESS,               typeof(Xmpp.protocol.extensions.compression.Compress));
            AddElementType("failure",           Uri.COMPRESS,               typeof(Xmpp.protocol.extensions.compression.Failure));
                    
            // MUC (JEP-0045 Multi User Chat)
            AddElementType("x",                 Uri.MUC,                    typeof(Xmpp.protocol.x.muc.Muc));
            AddElementType("x",                 Uri.MUC_USER,               typeof(Xmpp.protocol.x.muc.User));
            AddElementType("item",              Uri.MUC_USER,               typeof(Xmpp.protocol.x.muc.Item));
            AddElementType("status",            Uri.MUC_USER,               typeof(Xmpp.protocol.x.muc.Status));
            AddElementType("invite",            Uri.MUC_USER,               typeof(Xmpp.protocol.x.muc.Invite));
            AddElementType("decline",           Uri.MUC_USER,               typeof(Xmpp.protocol.x.muc.Decline));
            AddElementType("actor",             Uri.MUC_USER,               typeof(Xmpp.protocol.x.muc.Actor));
            AddElementType("history",           Uri.MUC,                    typeof(Xmpp.protocol.x.muc.History));
            AddElementType("query",             Uri.MUC_ADMIN,              typeof(Xmpp.protocol.x.muc.iq.admin.Admin));
            AddElementType("item",              Uri.MUC_ADMIN,              typeof(Xmpp.protocol.x.muc.iq.admin.Item));
            AddElementType("query",             Uri.MUC_OWNER,              typeof(Xmpp.protocol.x.muc.iq.owner.Owner));
            AddElementType("destroy",           Uri.MUC_OWNER,              typeof(Xmpp.protocol.x.muc.owner.Destroy));
            AddElementType("destroy",           Uri.MUC_USER,               typeof(Xmpp.protocol.x.muc.user.Destroy));
            

            //Jabber RPC JEP 0009            
            AddElementType("query",             Uri.IQ_RPC,                 typeof(Xmpp.protocol.iq.rpc.Rpc));
            AddElementType("methodCall",        Uri.IQ_RPC,                 typeof(Xmpp.protocol.iq.rpc.MethodCall));
            AddElementType("methodResponse",    Uri.IQ_RPC,                 typeof(Xmpp.protocol.iq.rpc.MethodResponse));

            // Chatstates Jep-0085
            AddElementType("active",            Uri.CHATSTATES,             typeof(Xmpp.protocol.extensions.chatstates.Active));
            AddElementType("inactive",          Uri.CHATSTATES,             typeof(Xmpp.protocol.extensions.chatstates.Inactive));
            AddElementType("composing",         Uri.CHATSTATES,             typeof(Xmpp.protocol.extensions.chatstates.Composing));
            AddElementType("paused",            Uri.CHATSTATES,             typeof(Xmpp.protocol.extensions.chatstates.Paused));
            AddElementType("gone",              Uri.CHATSTATES,             typeof(Xmpp.protocol.extensions.chatstates.Gone));

            // Jivesoftware Extenstions
            AddElementType("phone-event",       Uri.JIVESOFTWARE_PHONE,     typeof(Xmpp.protocol.extensions.jivesoftware.phone.PhoneEvent));
            AddElementType("phone-action",      Uri.JIVESOFTWARE_PHONE,     typeof(Xmpp.protocol.extensions.jivesoftware.phone.PhoneAction));
            AddElementType("phone-status",      Uri.JIVESOFTWARE_PHONE,     typeof(Xmpp.protocol.extensions.jivesoftware.phone.PhoneStatus));

            // Jingle stuff is in heavy development, we commit this once the most changes on the Jeps are done            
            //AddElementType("jingle",            Uri.JINGLE,                 typeof(Xmpp.protocol.extensions.jingle.Jingle));
            //AddElementType("candidate",         Uri.JINGLE,                 typeof(Xmpp.protocol.extensions.jingle.Candidate));

            AddElementType("c",                 Uri.CAPS,                   typeof(Xmpp.protocol.extensions.caps.Capabilities));

            AddElementType("geoloc",            Uri.GEOLOC,                 typeof(Xmpp.protocol.extensions.geoloc.GeoLoc));

            // Xmpp Ping
            AddElementType("ping",              Uri.PING,                   typeof(Xmpp.protocol.extensions.ping.Ping));

            //Ad-Hock Commands
            AddElementType("command",           Uri.COMMANDS,               typeof(Xmpp.protocol.extensions.commands.Command));
            AddElementType("actions",           Uri.COMMANDS,               typeof(Xmpp.protocol.extensions.commands.Actions));
            AddElementType("note",              Uri.COMMANDS,               typeof(Xmpp.protocol.extensions.commands.Note));

            // **********
            // * PubSub *
            // **********
            // Owner namespace
            AddElementType("affiliate",         Uri.PUBSUB_OWNER,           typeof(Xmpp.protocol.extensions.pubsub.owner.Affiliate));
            AddElementType("affiliates",        Uri.PUBSUB_OWNER,           typeof(Xmpp.protocol.extensions.pubsub.owner.Affiliates));
            AddElementType("configure",         Uri.PUBSUB_OWNER,           typeof(Xmpp.protocol.extensions.pubsub.owner.Configure));
            AddElementType("delete",            Uri.PUBSUB_OWNER,           typeof(Xmpp.protocol.extensions.pubsub.owner.Delete));
            AddElementType("pending",           Uri.PUBSUB_OWNER,           typeof(Xmpp.protocol.extensions.pubsub.owner.Pending));
            AddElementType("pubsub",            Uri.PUBSUB_OWNER,           typeof(Xmpp.protocol.extensions.pubsub.owner.PubSub));
            AddElementType("purge",             Uri.PUBSUB_OWNER,           typeof(Xmpp.protocol.extensions.pubsub.owner.Purge));
            AddElementType("subscriber",        Uri.PUBSUB_OWNER,           typeof(Xmpp.protocol.extensions.pubsub.owner.Subscriber));
            AddElementType("subscribers",       Uri.PUBSUB_OWNER,           typeof(Xmpp.protocol.extensions.pubsub.owner.Subscribers));

            // Event namespace
            AddElementType("delete",            Uri.PUBSUB_EVENT,           typeof(Xmpp.protocol.extensions.pubsub.@event.Delete));
            AddElementType("event",             Uri.PUBSUB_EVENT,           typeof(Xmpp.protocol.extensions.pubsub.@event.Event));
            AddElementType("item",              Uri.PUBSUB_EVENT,           typeof(Xmpp.protocol.extensions.pubsub.@event.Item));
            AddElementType("items",             Uri.PUBSUB_EVENT,           typeof(Xmpp.protocol.extensions.pubsub.@event.Items));
            AddElementType("purge",             Uri.PUBSUB_EVENT,           typeof(Xmpp.protocol.extensions.pubsub.@event.Purge));

            // Main Pubsub namespace
            AddElementType("affiliation",       Uri.PUBSUB,                 typeof(Xmpp.protocol.extensions.pubsub.Affiliation));
            AddElementType("affiliations",      Uri.PUBSUB,                 typeof(Xmpp.protocol.extensions.pubsub.Affiliations));
            AddElementType("configure",         Uri.PUBSUB,                 typeof(Xmpp.protocol.extensions.pubsub.Configure));
            AddElementType("create",            Uri.PUBSUB,                 typeof(Xmpp.protocol.extensions.pubsub.Create));
            AddElementType("configure",         Uri.PUBSUB,                 typeof(Xmpp.protocol.extensions.pubsub.Configure));
            AddElementType("item",              Uri.PUBSUB,                 typeof(Xmpp.protocol.extensions.pubsub.Item));
            AddElementType("items",             Uri.PUBSUB,                 typeof(Xmpp.protocol.extensions.pubsub.Items));
            AddElementType("options",           Uri.PUBSUB,                 typeof(Xmpp.protocol.extensions.pubsub.Options));
            AddElementType("publish",           Uri.PUBSUB,                 typeof(Xmpp.protocol.extensions.pubsub.Publish));
            AddElementType("pubsub",            Uri.PUBSUB,                 typeof(Xmpp.protocol.extensions.pubsub.PubSub));
            AddElementType("retract",           Uri.PUBSUB,                 typeof(Xmpp.protocol.extensions.pubsub.Retract));
            AddElementType("subscribe",         Uri.PUBSUB,                 typeof(Xmpp.protocol.extensions.pubsub.Subscribe));
            AddElementType("subscribe-options", Uri.PUBSUB,                 typeof(Xmpp.protocol.extensions.pubsub.SubscribeOptions));
            AddElementType("subscription",      Uri.PUBSUB,                 typeof(Xmpp.protocol.extensions.pubsub.Subscription));
            AddElementType("subscriptions",     Uri.PUBSUB,                 typeof(Xmpp.protocol.extensions.pubsub.Subscriptions));
            AddElementType("unsubscribe",       Uri.PUBSUB,                 typeof(Xmpp.protocol.extensions.pubsub.Unsubscribe));           

            // HTTP Binding XEP-0124
            AddElementType("body",              Uri.HTTP_BIND,              typeof(Xmpp.protocol.extensions.bosh.Body));

            // Message receipts XEP-0184
            AddElementType("received",          Uri.MSG_RECEIPT,            typeof(Xmpp.protocol.extensions.msgreceipts.Received));
            AddElementType("request",           Uri.MSG_RECEIPT,            typeof(Xmpp.protocol.extensions.msgreceipts.Request));

            // Bookmark storage XEP-0048         
            AddElementType("storage",           Uri.STORAGE_BOOKMARKS,      typeof(Xmpp.protocol.extensions.bookmarks.Storage));
            AddElementType("url",               Uri.STORAGE_BOOKMARKS,      typeof(Xmpp.protocol.extensions.bookmarks.Url));
            AddElementType("conference",        Uri.STORAGE_BOOKMARKS,      typeof(Xmpp.protocol.extensions.bookmarks.Conference));
            
            // XEP-0047: In-Band Bytestreams (IBB)
            AddElementType("open",              Uri.IBB,                    typeof(Xmpp.protocol.extensions.ibb.Open));
            AddElementType("data",              Uri.IBB,                    typeof(Xmpp.protocol.extensions.ibb.Data));
            AddElementType("close",             Uri.IBB,                    typeof(Xmpp.protocol.extensions.ibb.Close));
                    
            // XEP-0153: vCard-Based Avatars
            AddElementType("x",                 Uri.VCARD_UPDATE,           typeof(Xmpp.protocol.x.vcard_update.VcardUpdate));

            // AMP
            AddElementType("amp",               Uri.AMP,                    typeof(Xmpp.protocol.extensions.amp.Amp));
            AddElementType("rule",              Uri.AMP,                    typeof(Xmpp.protocol.extensions.amp.Rule));

            // Urn Time
            AddElementType("time",              Uri.URN_TIME,               typeof(Xmpp.protocol.time.Time));

            // XEP-0145 Annotations
            AddElementType("storage",           Uri.STORAGE_ROSTERNOTES,    typeof(Xmpp.protocol.extensions.bookmarks.RosterNotes));
            AddElementType("note",              Uri.STORAGE_ROSTERNOTES,    typeof(Xmpp.protocol.extensions.bookmarks.RosterNote));
		}		
		
		/// <summary>
		/// Adds new Element Types to the Hashtable
		/// Use this function also to register your own created Elements.
        /// If a element is already registered it gets overwritten. This behaviour is also useful if you you want to overwrite
        /// classes and add your own derived classes to the factory.
		/// </summary>
		/// <param name="tag">FQN</param>
		/// <param name="ns"></param>
		/// <param name="t"></param>
		public static void AddElementType(string tag, string ns, System.Type t)
		{
            ElementType et = new ElementType(tag, ns);
            string key = et.ToString();
            // added thread safety on a user request
            lock (m_table)
            {
                if (m_table.ContainsKey(key))
                    m_table[key] = t;
                else
                    m_table.Add(et.ToString(), t);
            }
		}
        
		/// <summary>
		/// 
		/// </summary>
		/// <param name="prefix"></param>
		/// <param name="tag"></param>
		/// <param name="ns"></param>
		/// <returns></returns>
		public static Element GetElement(string prefix, string tag, string ns)
		{
			if (ns == null)
				ns = "";

			ElementType et = new ElementType(tag, ns);			
			System.Type t = (System.Type) m_table[et.ToString()];

			Element ret;			
			if (t != null)
				ret = (Element) System.Activator.CreateInstance(t);				
			else
			    ret = new Element(tag);				
			
			ret.Prefix = prefix;

			if (ns!="")
				ret.Namespace = ns;
			
			return ret;
		}		
	}  
}