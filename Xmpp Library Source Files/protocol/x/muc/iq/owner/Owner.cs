using Xmpp.Xml.Dom;

namespace Xmpp.protocol.x.muc.iq.owner
{
// --------------------------------------------------------------------------------
/// <summary>
/// <iq id="jcl_110" to="xxxxxx@conference.jabber.org" type="set">
/// <query xmlns="http://jabber.org/protocol/muc#owner">
/// <x type="submit" xmlns="jabber:x:data"/>
/// </query>
/// </iq>
/// </summary>
// --------------------------------------------------------------------------------

    public class Owner : Element
    {

        public Owner()
        {
            TagName    = "query";
            Namespace  = Uri.MUC_OWNER;           
        }        
    }
}