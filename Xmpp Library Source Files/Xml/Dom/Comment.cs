

namespace Xmpp.Xml.Dom
{
	/// <summary>
	/// Summary description for Comment.
	/// </summary>
	public class Comment : Node
	{
		public Comment()
		{
			NodeType = NodeType.Comment;
		}
		
		public Comment(string text) : this()
		{
			Value = text;
		}
	}
	
}
