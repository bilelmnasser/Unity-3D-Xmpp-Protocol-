using System;
using System.Collections;
namespace Xmpp.Xml.Dom
{
	/// <summary>
	/// 
	/// </summary>	
	public class NodeList : CollectionBase
    {
		/// <summary>
		/// Owner (Parent) of the ChildElement Collection
		/// </summary>
		private Node m_Owner		= null;

		public NodeList()
		{			
		}

		public NodeList(Node owner) 
		{
			m_Owner = owner;            
		}

        public void Add(Node e)
        {
            // can't add a empty node, so return immediately
            // Some people tried this which caused an error
            if (e == null)
                return;

            if (m_Owner != null)
            {
                e.Parent = m_Owner;
                if (e.Namespace == null)
                    e.Namespace = m_Owner.Namespace;
            }

            e.m_Index = Count;

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
			RebuildIndex(index);
		}
	
		public void Remove(Element e)
		{
			int idx = e.Index;
			List.Remove(e);
			RebuildIndex(idx);
		}
	
		public Node Item(int index) 
		{
			return (Node) this.List[index];
		}

        public object[] ToArray()
        {
            object[] ar = new object[this.List.Count];
            for (int i = 0; i < this.List.Count; i++)
            {
                ar[i] = this.List[i];
            }
            return ar;
        }

		internal void RebuildIndex()
		{
            RebuildIndex(0);
		}

		internal void RebuildIndex(int start)
		{
			for (int i = start; i < Count; i++)
			{
                Node node = (Node) List[i];
				node.m_Index = i;
			}			
		}       
    }
}