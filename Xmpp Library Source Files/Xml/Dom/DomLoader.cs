using System.IO;

namespace Xmpp.Xml.Dom
{
	/// <summary>
	/// internal class that loads a xml document from a string or stream
	/// </summary>
	internal class DomLoader
	{	
		public static void Load(string xml, Document doc)
		{
            var sp =new StreamParser();

            sp.OnStreamStart += (sender, node) => doc.ChildNodes.Add(node);
            sp.OnStreamElement += (sender, node) => doc.RootElement.ChildNodes.Add(node);
            
            
			byte[] b = System.Text.Encoding.UTF8.GetBytes(xml);
			sp.Push(b, 0, b.Length);
		}

		public static void Load(StreamReader sr, Document doc)
		{
		    Load(sr.ReadToEnd(), doc);
		}
	}
}