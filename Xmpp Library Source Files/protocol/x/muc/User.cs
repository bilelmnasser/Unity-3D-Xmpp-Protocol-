using System.Collections.Generic;
using Xmpp.Xml.Dom;

namespace Xmpp.protocol.x.muc
{
	/// <summary>
	/// Summary description for MucUser.
	/// </summary>
	public class User : Element
	{
        /*
        <x xmlns='http://jabber.org/protocol/muc#user'>
             <item affiliation='admin' role='moderator'/>
        </x>
         
        <message from='darkcave@macbeth.shakespeare.lit'
                 to='hag66@shakespeare.lit/pda'
                 type='groupchat'>
            <body>This room is not anonymous.</body>
            <x xmlns='http://jabber.org/protocol/muc#user'>
                <status code='100'/>
            </x>
        </message>
         
        <message
            from='crone1@shakespeare.lit/desktop'
            to='darkcave@macbeth.shakespeare.lit'>
          <x xmlns='http://jabber.org/protocol/muc#user'>
            <invite to='hecate@shakespeare.lit'>
              <reason>
                Hey Hecate, this is the place for all good witches!
              </reason>
            </invite>
          </x>
        </message>
         
        <message
            from='darkcave@macbeth.shakespeare.lit'
            to='hecate@shakespeare.lit'>
          <body>You have been invited to darkcave@macbeth by crone1@shakespeare.lit.</body>
          <x xmlns='http://jabber.org/protocol/muc#user'>
            <invite from='crone1@shakespeare.lit'>
              <reason>
                Hey Hecate, this is the place for all good witches!
              </reason>
            </invite>
            <password>cauldron</password>
          </x>
          <x jid='darkcave@macbeth.shakespeare.lit' xmlns='jabber:x:conference'>
            Hey Hecate, this is the place for all good witches!
          </x>
        </message>
        
        */
        public User()
		{
			TagName	= "x";
			Namespace	= Uri.MUC_USER;
		}

        public Item Item
        {
            get
            {
                return SelectSingleElement(typeof(Item)) as Item;
            }
            set
            {
                RemoveTag(typeof(Item));
                AddChild(value);
            }
        }
        
        /// <summary>
        /// Gets or sets the status codes.
        /// </summary>
        /// <value>The status codes.</value>
        public List<Status> StatusCodes
        {
            get { return SelectElements<Status>(); }
            set
            {
                RemoveTags<Status>();
                foreach (Status status in value)
                    AddChild(status);
            }
        }

        /// <summary>
        /// The Status Element
        /// </summary>
        public Status Status
        {
            get { return SelectSingleElement(typeof(Status)) as Status; }
            set
            {
                if (HasTag(typeof(Status)))
                    RemoveTag(typeof(Status));
                
                if (value != null)
                    AddChild(value);
            }
        }

        /// <summary>
        /// The Invite Element
        /// </summary>
        public Invite Invite
        {
            get { return SelectSingleElement(typeof(Invite)) as Invite; }
            set
            {
                if (HasTag(typeof(Invite)))
                    RemoveTag(typeof(Invite));

                if (value != null)
                    AddChild(value);
            }
        }

        /// <summary>
        /// The Decline Element
        /// </summary>
        public Decline Decline
        {
            get { return SelectSingleElement(typeof(Decline)) as Decline; }
            set
            {
                if (HasTag(typeof(Decline)))
                    RemoveTag(typeof(Decline));

                if (value != null)
                    AddChild(value);
            }
        }

        public string Password
        {
            set { SetTag("password", value); }
            get { return GetTag("password"); }
        }
	}
}