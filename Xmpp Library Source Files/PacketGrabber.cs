using System;
using System.Collections;

namespace Xmpp
{
	/// <summary>
	/// Summary description for Grabber.
	/// </summary>
	public class PacketGrabber
	{
		internal Hashtable				m_grabbing		= new Hashtable();		
		internal XmppConnection	        m_connection	= null;

		public PacketGrabber()
		{
		}

		public void Clear()
		{
			// need locking here to make sure that we dont acces the Hashtable
			// from another thread
			lock(this)
			{
				m_grabbing.Clear();
			}
		}

        /// <summary>
        /// Pending request can be removed.
        /// This is useful when a ressource for the callback is destroyed and
        /// we are not interested anymore at the result.
        /// </summary>
        /// <param name="id">ID of the Iq we are not interested anymore</param>
        public void Remove(string id)
        {
            if (m_grabbing.ContainsKey(id))
                m_grabbing.Remove(id);
        }
	}
}
