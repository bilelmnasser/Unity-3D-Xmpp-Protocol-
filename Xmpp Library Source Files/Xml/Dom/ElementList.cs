

using System;
using System.Collections;

namespace Xmpp.Xml.Dom
{
    public class ElementList : CollectionBase
    {
        public void Add(Node e) 
		{
            // can't add a empty node, so return immediately
            // Some people tried dthis which caused an error
            if (e == null)
                return;
            
            List.Add(e);
		}
	
		// Method implementation from the CollectionBase class
		public void Remove(int index)
		{
			if (index > Count - 1 || index < 0) 
			{
				// Handle the error that occurs if the valid page index is       
				// not supplied.    
				// This exception will be written to the calling function             
				throw new Exception("Index out of bounds");            
			}        
			List.RemoveAt(index);			
		}
	
		public void Remove(Element e)
		{			
			List.Remove(e);			
		}
	
		public Element Item(int index) 
		{
			return (Element) List[index];
		}
    }
}