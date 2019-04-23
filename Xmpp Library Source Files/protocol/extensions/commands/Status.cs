using System;

namespace Xmpp.protocol.extensions.commands
{
    /*
     * <xs:attribute name='status' use='optional'>
        <xs:simpleType>
          <xs:restriction base='xs:NCName'>
            <xs:enumeration value='canceled'/>
            <xs:enumeration value='completed'/>
            <xs:enumeration value='executing'/>
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
    */
    public enum Status
    {
        NONE = -1,
        canceled,
        completed,
        executing
    }
}
