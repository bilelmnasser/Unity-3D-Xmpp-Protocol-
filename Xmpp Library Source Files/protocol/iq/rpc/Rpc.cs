using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.rpc
{
    
    /*         

        Example 1. A typical request

        <iq type='set' to='responder@company-a.com/jrpc-server' id='1'>
          <query xmlns='jabber:iq:rpc'>
            <methodCall>
              <methodName>examples.getStateName</methodName>
              <params>
                <param>
                  <value><i4>6</i4></value>
                </param>
              </params>
            </methodCall>
          </query>
        </iq>

        Example 2. A typical response

        <iq type='result' to='requester@company-b.com/jrpc-client' 
                    from='responder@company-a.com/jrpc-server' id='1'>
          <query xmlns='jabber:iq:rpc'>
            <methodResponse>
              <params>
                <param>
                  <value><string>Colorado</string></value>
                </param>
              </params>
            </methodResponse>
          </query>
        </iq>

    */
      
    /// <summary>
    /// JEP-0009: Jabber-RPC, transport RPC over Jabber/XMPP
    /// </summary>
    public class Rpc : Element
    {
        public Rpc()
        {
            TagName    = "query";
            Namespace  = Uri.IQ_RPC;
        }

        /// <summary>
        /// 
        /// </summary>
        public MethodCall MethodCall
        {
            get { return (MethodCall)SelectSingleElement(typeof(MethodCall)); }
            set
            {
                RemoveTag(typeof(MethodCall));
                if (value != null)
                    AddChild(value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public MethodResponse MethodResponse
        {
            get { return (MethodResponse)SelectSingleElement(typeof(MethodResponse)); }
            set
            {
                RemoveTag(typeof(MethodResponse));
                if (value != null)
                    AddChild(value);
            }
        }
        
    }
}
