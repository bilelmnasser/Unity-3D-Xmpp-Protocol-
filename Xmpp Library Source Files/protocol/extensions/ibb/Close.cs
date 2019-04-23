using System;
using System.Text;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.ibb
{
    /*
         <close xmlns='http://jabber.org/protocol/ibb' sid='mySID'/>      
    */

    /// <summary>
    /// 
    /// </summary>
    public class Close : Base
    {
        /// <summary>
        /// 
        /// </summary>
        public Close()
        {
            this.TagName = "close";           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sid"></param>
        public Close(string sid) : this()
        {
            this.Sid = sid;            
        }       
    }
}