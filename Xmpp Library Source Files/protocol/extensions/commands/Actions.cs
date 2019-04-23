
using System;
using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.commands
{
    /*
      <xs:element name='actions'>
        <xs:complexType>
          <xs:sequence>
            <xs:element name='prev' type='empty' minOccurs='0'/>
            <xs:element name='next' type='empty' minOccurs='0'/>
            <xs:element name='complete' type='empty' minOccurs='0'/>
          </xs:sequence>
          <xs:attribute name='execute' use='optional'>
            <xs:simpleType>
              <xs:restriction base='xs:NCName'>
                <xs:enumeration value='complete'/>
                <xs:enumeration value='next'/>
                <xs:enumeration value='prev'/>
              </xs:restriction>
            </xs:simpleType>
          </xs:attribute>
        </xs:complexType>
      </xs:element>
     
      <actions execute='complete'>
        <prev/>
        <complete/>
      </actions>
    */
    public class Actions : Element
    {
        public Actions()
        {
            this.TagName    = "actions";
            this.Namespace  = Uri.COMMANDS;
        }

        /// <summary>
        /// Optional Execute Action, only complete, next and previous is allowed
        /// </summary>
        public Action Execute
        {
			get 
			{ 
				return (Action) GetAttributeEnum("execute", typeof(Action)); 
			}
			set 
			{ 
				if (value == Action.NONE)
                    RemoveAttribute("execute");
				else
                    SetAttribute("execute", value.ToString());
			}
		}


        /// <summary>
        /// 
        /// </summary>
        public bool Complete
        {
            get { return HasTag("complete"); }
            set
            {
                if (value)
                    this.SetTag("complete");
                else
                    this.RemoveTag("complete");
            }
        }

        public bool Next
        {
            get { return HasTag("next"); }
            set
            {
                if (value)
                    this.SetTag("next");
                else
                    this.RemoveTag("next");
            }
        }

        public bool Previous
        {
            get { return HasTag("prev"); }
            set
            {
                if (value)
                    this.SetTag("prev");
                else
                    this.RemoveTag("prev");
            }
        }

        /// <summary>
        /// Actions, only complete, prev and next are allowed here and can be combined
        /// </summary>
        public Action Action
        {
            get
            {
                Action res = 0;
                
                if (Complete)
                    res |= Action.complete;
                if (Previous)
                    res |= Action.prev;
                if (Next)
                    res |= Action.next;

                if (res == 0)
                    return Action.NONE;
                else
                    return res;
            }
            set
            {
                if (value == Action.NONE)
                {                    
                    Complete    = false;
                    Previous    = false;                    
                    Next        = false;
                }
                else
                {
                    Complete    = ((value & Action.complete) == Action.complete);
                    Previous    = ((value & Action.prev) == Action.prev);
                    Next        = ((value & Action.next) == Action.next);                    
                }
            }
        }
    }
}