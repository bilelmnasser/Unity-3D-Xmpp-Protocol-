using System;
using System.Collections;

using Xmpp.Sasl;
using Xmpp.Sasl.Facebook;
using Xmpp.Sasl.Plain;
using Xmpp.Sasl.DigestMD5;
using Xmpp.Sasl.Anonymous;
using Xmpp.Sasl.XGoogleToken;
#if !(CF || CF_2)
using Xmpp.Sasl.Scram;
#endif

namespace Xmpp.Factory
{
	/// <summary>
	/// SASL factory
	/// </summary>
	public class SaslFactory
	{
		/// <summary>
		/// This Hashtable stores Mapping of mechanism <--> SASL class in Xmpp
		/// </summary>
		private static readonly Hashtable m_table = new Hashtable();

		static SaslFactory()
		{
			AddMechanism(protocol.sasl.Mechanism.GetMechanismName(protocol.sasl.MechanismType.PLAIN),		        typeof(PlainMechanism));
			AddMechanism(protocol.sasl.Mechanism.GetMechanismName(protocol.sasl.MechanismType.DIGEST_MD5),	        typeof(DigestMD5Mechanism));
            AddMechanism(protocol.sasl.Mechanism.GetMechanismName(protocol.sasl.MechanismType.ANONYMOUS),           typeof(AnonymousMechanism));
            AddMechanism(protocol.sasl.Mechanism.GetMechanismName(protocol.sasl.MechanismType.X_GOOGLE_TOKEN),      typeof(XGoogleTokenMechanism));
            AddMechanism(protocol.sasl.Mechanism.GetMechanismName(protocol.sasl.MechanismType.X_FACEBOOK_PLATFORM), typeof(FacebookMechanism));
#if !(CF || CF_2)
            AddMechanism(protocol.sasl.Mechanism.GetMechanismName(protocol.sasl.MechanismType.SCRAM_SHA_1),         typeof(ScramSha1Mechanism));
          
#endif
		}


		public static Mechanism GetMechanism(string mechanism)
		{
			var t = (Type) m_table[mechanism];
			if (t != null)
				return (Mechanism) Activator.CreateInstance(t);
			else
				return null;			
		}
		
		/// <summary>
		/// Adds new Element Types to the Hashtable
		/// Use this function to register new SASL mechanisms
		/// </summary>
		/// <param name="mechanism"></param>
		/// <param name="t"></param>
		public static void AddMechanism(string mechanism, System.Type t)
		{
			m_table.Add( mechanism, t);
		}
	}
}
