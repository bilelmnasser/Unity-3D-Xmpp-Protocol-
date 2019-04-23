using System;
using System.Text;

namespace Xmpp.Factory
{
    /// <summary>
    /// 
    /// </summary>
    public class ElementType
    {
        private string m_TagName;
        private string m_Namespace;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TagName"></param>
        /// <param name="Namespace"></param>
        public ElementType(string TagName, string Namespace)
        {
            this.m_TagName      = TagName;
            this.m_Namespace    = Namespace;
        }

        public override string ToString()
        {
            if ((m_Namespace != null) && (m_Namespace != string.Empty))
            {
                return (m_Namespace + ":" + m_TagName);
            }
            return m_TagName;
        }
    }
}
