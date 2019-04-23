using System;

using Xmpp.protocol.client;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.featureneg
{
	/// <summary>
	/// JEP-0020: Feature Negotiation
	/// This JEP defines a A protocol that enables two Jabber entities to mutually negotiate feature options.
	/// </summary>
	public class FeatureNegIq : IQ
	{
		/*
		<iq type='get'
			from='romeo@montague.net/orchard'
			to='juliet@capulet.com/balcony'
			id='neg1'>
			<feature xmlns='http://jabber.org/protocol/feature-neg'>
				<x xmlns='jabber:x:data' type='form'>
					<field type='list-single' var='places-to-meet'>
						<option><value>Lover's Lane</value></option>
						<option><value>Secret Grotto</value></option>
						<option><value>Verona Park</value></option>
					</field>
					<field type='list-single' var='times-to-meet'>
						<option><value>22:00</value></option>
						<option><value>22:30</value></option>
						<option><value>23:00</value></option>
						<option><value>23:30</value></option>
					</field>
				</x>
			</feature>
		</iq>
		*/

		private FeatureNeg m_FeatureNeg = new FeatureNeg();

		public FeatureNegIq()
		{		
			this.AddChild(m_FeatureNeg);
			this.GenerateId();
		}

		public FeatureNegIq(IqType type) : this()
		{			
			this.Type = type;		
		}	

		public FeatureNeg FeatureNeg
		{
			get
			{
				return m_FeatureNeg;
			}
		}
	}
}
