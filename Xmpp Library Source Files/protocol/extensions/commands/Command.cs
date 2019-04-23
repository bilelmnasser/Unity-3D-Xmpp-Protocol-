

using System;

using Xmpp.Xml.Dom;
using Xmpp.protocol.x.data;

namespace Xmpp.protocol.extensions.commands
{
    public class Command : Element
    {
        #region << Constructors >>
        public Command()
        {
            this.TagName    = "command";
            this.Namespace  = Uri.COMMANDS;
        }

        public Command(string node) : this()
        {
            this.Node = node;
        }

        public Command(Action action) : this()
        {
            this.Action = action;
        }

        public Command(Status status) : this()
        {
            this.Status = status;
        }

        public Command(string node, string sessionId) : this(node)
        {
            this.SessionId = sessionId;
        }

        public Command(string node, string sessionId, Action action) : this(node, sessionId)
        {
            this.Action = action;
        }

        public Command(string node, string sessionId, Status status) : this(node, sessionId)
        {
            this.Status = status;
        }

        public Command(string node, string sessionId, Action action, Status status) : this(node, sessionId, action)
        {
            this.Status = status;
        }
        #endregion

        public Action Action
		{
			get 
			{ 
				return (Action) GetAttributeEnum("action", typeof(Action)); 
			}
			set
			{ 
				if (value == Action.NONE)
					RemoveAttribute("action");
				else
					SetAttribute("action", value.ToString());
			}
		}

        public Status Status
        {
            get
            {
                return (Status) GetAttributeEnum("status", typeof(Status));
            }
            set
            {
                if (value == Status.NONE)
                    RemoveAttribute("status");
                else
                    SetAttribute("status", value.ToString());
            }
        }


        // <xs:attribute name='node' type='xs:string' use='required'/>
        
        /// <summary>
        /// Node is Required
        /// </summary>
        public string Node
        {
            get { return GetAttribute("node"); }
            set { SetAttribute("node", value); }
        }

        // <xs:attribute name='sessionid' type='xs:string' use='optional'/>
        public string SessionId
        {
            get { return GetAttribute("sessionid"); }
            set { SetAttribute("sessionid", value); }
        }
      
        /// <summary>
        /// The X-Data Element
        /// </summary>
        public Data Data
        {
            get
            {
                return SelectSingleElement(typeof(Data)) as Data;

            }
            set
            {
                if (HasTag(typeof(Data)))
                    RemoveTag(typeof(Data));

                if (value != null)
                    this.AddChild(value);
            }
        }

        public Note Note
        {
            get
            {
                return SelectSingleElement(typeof(Note)) as Note;

            }
            set
            {
                if (HasTag(typeof(Note)))
                    RemoveTag(typeof(Note));
                
                if (value != null)
                    this.AddChild(value);
            }
        }

        public Actions Actions
        {
            get
            {
                return SelectSingleElement(typeof(Actions)) as Actions;

            }
            set
            {
                if (HasTag(typeof(Actions)))
                    RemoveTag(typeof(Actions));

                if (value != null)
                    this.AddChild(value);
            }
        }

    }
}
