
using System;
using System.IO;
using System.Text;

namespace Xmpp.IO
{
	/// <summary>
	/// This class is inherited from the StringWriter Class
	/// The standard StringWriter class supports no encoding
	/// With this Class we can set the Encoding of a StringWriter in the Constructor
	/// </summary>
	public class StringWriterWithEncoding : StringWriter
	{
		Encoding m_Encoding;

		public StringWriterWithEncoding (Encoding encoding)
		{
			this.m_Encoding = encoding;
			
		}

		public override Encoding Encoding
		{
			get
			{
				return m_Encoding; 
			}
		}
	}
}