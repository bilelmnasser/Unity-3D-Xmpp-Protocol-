using System;
using System.Text;

namespace Xmpp.protocol.x.muc.iq.admin
{
    public class Item : Xmpp.protocol.x.muc.Item
    {
        /// <summary>
        /// 
        /// </summary>
        public Item() : base()
        {
            this.Namespace = Uri.MUC_ADMIN;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="affiliation"></param>
        public Item(Affiliation affiliation) : this()
        {
            this.Affiliation = affiliation;
        }

        public Item(Affiliation affiliation, Jid jid) : this(affiliation)
        {
            this.Jid = jid;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="role"></param>
        public Item(Role role) : this()
        {
            this.Role = role;
        }

        public Item(Role role, Jid jid) : this(role)
        {
            this.Jid = jid;
        }

        public Item(Jid jid) : this()
        {
            this.Jid = jid;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="affiliation"></param>
        /// <param name="role"></param>
        public Item(Affiliation affiliation, Role role) : this(affiliation)
        {
            this.Role = role;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="affiliation"></param>
        /// <param name="role"></param>
        /// <param name="jid"></param>
        public Item(Affiliation affiliation, Role role, Jid jid) : this(affiliation, role)
        {
            this.Jid = jid;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="affiliation"></param>
        /// <param name="role"></param>
        /// <param name="reason"></param>
        public Item(Affiliation affiliation, Role role, string reason) : this(affiliation, role)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="affiliation"></param>
        /// <param name="role"></param>
        /// <param name="jid"></param>
        /// <param name="reason"></param>
        public Item(Affiliation affiliation, Role role, Jid jid, string reason) : this(affiliation, role, jid)
        {
            this.Reason = reason;
        }

    }
}
