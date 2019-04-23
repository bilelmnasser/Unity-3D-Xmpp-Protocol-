using System;

using Xmpp.Xml;
using Xmpp.Xml.Dom;

//	<mechanisms xmlns='urn:ietf:params:xml:ns:xmpp-sasl'>
//		<mechanism>DIGEST-MD5</mechanism>
//		<mechanism>PLAIN</mechanism>
//	</mechanisms>
namespace Xmpp.protocol.sasl
{
	/// <summary>
	/// Summary description for Mechanisms.
	/// </summary>
	public class Mechanisms : Element
	{
		public Mechanisms()
		{
			this.TagName	= "mechanisms";
			this.Namespace	= Uri.SASL;
		}

		public Mechanism[] GetMechanisms()
		{

            ElementList elements = SelectElements("mechanism");			

            Mechanism[] items = new Mechanism[elements.Count];
            int i=0;
            foreach (Element e in elements)
            {
                items[i] = (Mechanism) e;
                i++;
            }
            return items;
		}

		public bool SupportsMechanism(MechanismType type)
		{
			foreach( Mechanism m in GetMechanisms())
			{
				if (m.MechanismType == type)
					return true;
			}
			return false;
		}

        /// <summary>
        /// Gets the given mechanism.
        /// </summary>
        /// <param name="type">The mechanism type.</param>
        /// <returns></returns>
        public Mechanism GetMechanism(MechanismType type)
        {
            foreach (Mechanism m in GetMechanisms())
            {
                if (m.MechanismType == type)
                    return m;
            }
            return null;
        }
	}
}
