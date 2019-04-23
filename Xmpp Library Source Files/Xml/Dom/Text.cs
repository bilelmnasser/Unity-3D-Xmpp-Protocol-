namespace Xmpp.Xml.Dom
{
	/// <summary>
	/// 
	/// </summary>
	public class Text : Node
	{
		public Text()
		{
			NodeType = NodeType.Text;
		}
		
		public Text(string text) : this()
		{
			Value = text;
		}
	}
}
