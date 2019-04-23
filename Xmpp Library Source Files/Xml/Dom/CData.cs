

namespace Xmpp.Xml.Dom
{
    /// <summary>
    /// 
    /// </summary>
    public class CData : Node
    {
        public CData()
        {
            NodeType = NodeType.Cdata;
        }

        public CData(string data)
            : this()
        {
            Value = data;
        }
    }
}