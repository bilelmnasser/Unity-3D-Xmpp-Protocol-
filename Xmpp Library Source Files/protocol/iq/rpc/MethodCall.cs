using System.Collections;
using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.rpc
{    

    /// <summary>
    /// The methodCall element.     
    /// </summary>
    public class MethodCall : Element
    {
        /*
        
         <methodCall>
            <methodName>examples.getStateName</methodName>
            <params>
                <param><value><i4>41</i4></value></param>
            </params>
         </methodCall>        
         
        */

        /// <summary>
        /// 
        /// </summary>
        public MethodCall()
        {
            TagName    = "methodCall";
            Namespace  = Uri.IQ_RPC;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="methodName"></param>
        /// <param name="Params"></param>
        public MethodCall(string methodName, ArrayList Params) : this()
        {
            WriteCall(methodName, Params);            
        }

        /// <summary>
        /// 
        /// </summary>
        public string MethodName
		{
			set	{ SetTag("methodName", value); }
            get { return GetTag("methodName"); }
		}

        /// <summary>
        /// Write the functions call with params to this Element
        /// </summary>
        /// <param name="name"></param>
        /// <param name="Params"></param>
        public void WriteCall(string name, ArrayList Params)
        {
            MethodName = name;

            // remove this tag if exists, in case this function gets
            // calles multiple times by some guys
            RemoveTag("params");
            
            var elParams = RpcHelper.WriteParams(Params);

            if (elParams != null)
                AddChild(elParams);
        }
        
    }
}
