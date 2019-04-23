using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.x.muc
{
	/// <summary>
	/// Summary description for Item.
	/// </summary>
	public class Item : Xmpp.protocol.Base.Item
	{
        /*
        <x xmlns='http://jabber.org/protocol/muc#user'>
             <item affiliation='admin' role='moderator'/>
        </x>
         
        <item nick='pistol' role='none'>
            <reason>Avaunt, you cullion!</reason>
        </item>
        
        <presence
                from='darkcave@macbeth.shakespeare.lit/thirdwitch'
                to='crone1@shakespeare.lit/desktop'>
                <x xmlns='http://jabber.org/protocol/muc#user'>
                    <item   affiliation='none'
                            jid='hag66@shakespeare.lit/pda'
                            role='participant'/>
                </x>
        </presence>
        */

        /// <summary>
        /// 
        /// </summary>
		public Item() : base()
		{			
            this.TagName    = "item";
			this.Namespace  = Uri.MUC_USER;
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="affiliation"></param>
        public Item(Affiliation affiliation) : this()
        {
            this.Affiliation = affiliation;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="role"></param>
        public Item(Role role) : this()
        {
            this.Role = role;
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
        /// <param name="reason"></param>
        public Item(Affiliation affiliation, Role role, string reason) : this(affiliation, role)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// 
        /// </summary>
		public Role Role
		{
			get { return (Role) GetAttributeEnum("role", typeof(Role)); }
			set { SetAttribute("role", value.ToString()); }
		}

        /// <summary>
        /// 
        /// </summary>
		public Affiliation Affiliation
		{
			get { return (Affiliation) GetAttributeEnum("affiliation", typeof(Affiliation)); }
			set { SetAttribute("affiliation", value.ToString()); }
		}

        /// <summary>
        /// 
        /// </summary>
        public string Nickname
        {
            get { return GetAttribute("nick"); }
            set { SetAttribute("nick", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Reason
        {
            set { SetTag("reason", value); }
            get { return GetTag("reason"); }
        }

        public Actor Actor
        {
            get
            {
                return SelectSingleElement(typeof(Actor)) as Actor;
            }
            set
            {
                if (HasTag(typeof(Actor)))
                    RemoveTag(typeof(Actor));

                if (value != null)
                    this.AddChild(value);
            }
        }
	}
}