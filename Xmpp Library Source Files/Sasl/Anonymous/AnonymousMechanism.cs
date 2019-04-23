
using Xmpp.Xml.Dom;
using Xmpp.protocol.sasl;

namespace Xmpp.Sasl.Anonymous
{
    /// <summary>
    /// SALS ANONYMOUS Mechanism, this allows anonymous logins to a xmpp server.
    /// </summary>
    public class AnonymousMechanism : Mechanism
    {
        /*****
            S: <stream:features>
                    <mechanisms xmlns='urn:ietf:params:xml:ns:xmpp-sasl'>
                        <mechanism>DIGEST-MD5<mechanism>
                        <mechanism>ANONYMOUS<mechanism>
                    </mechanisms>
               </stream:features>
            
            * So, the proper exchange for this ANONYMOUS mechanism would be:

            C: <auth xmlns='urn:ietf:params:xml:ns:xmpp-sasl' mechanism='ANONYMOUS'/>
            S: <success xmlns='urn:ietf:params:xml:ns:xmpp-sasl'/>

            or, in case of the optional trace information:

            C: <auth xmlns='urn:ietf:params:xml:ns:xmpp-sasl' mechanism='ANONYMOUS'>
                    c2lyaGM=
               </auth>
            S: <success xmlns='urn:ietf:params:xml:ns:xmpp-sasl'/>

        *****/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="con"></param>
        public override void Init(XmppClientConnection con)
        {            
            con.Send(new Auth(MechanismType.ANONYMOUS));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public override void Parse(Node e)
        {
            // *No Challenges* in SASL ANONYMOUS
        }
    }
}