using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.bookmarks
{
    /// <summary>
    /// 
    /// </summary>
    public class RosterNotes : Element
    {
        /*
            <iq type='result' id='a2'>
                <query xmlns='jabber:iq:private'>
                    <storage xmlns='storage:rosternotes'>
                        <note jid='hamlet@shakespeare.lit'
                            cdate='2004-09-24T15:23:21Z'
                            mdate='2004-09-24T15:23:21Z'>Seems to be a good writer</note>
                        <note jid='juliet@capulet.com'
                            cdate='2004-09-27T17:23:14Z'
                            mdate='2004-09-28T12:43:12Z'>Oh my sweetest love ...</note>
                    </storage>
                </query>
            </iq> 
        */
        public RosterNotes()
        {
            TagName    = "storage";
            Namespace = Uri.STORAGE_ROSTERNOTES;
        }

        /// <summary>
        /// Add a note to the storage object
        /// </summary>
        /// <param name="note">The note.</param>
        /// <returns></returns>
        public RosterNote AddNote(RosterNote note)
        {
            AddChild(note);
            return note;
        }

        /// <summary>
        /// Add a note to the storage object
        /// </summary>
        /// <param name="jid"></param>
        /// <param name="cdate"></param>
        /// <param name="mdate"></param>
        /// <param name="note"></param>
        /// <returns></returns>
        public RosterNote AddNote(Jid jid, DateTime cdate, DateTime mdate, string note)
        {
            return AddNote(new RosterNote(jid, cdate, mdate, note));
        }

        /// <summary>
        /// get all roster notes
        /// </summary>
        /// <returns></returns>
        public RosterNote[] GetRosterNotes()
        {
            ElementList nl = SelectElements(typeof(RosterNote));
            RosterNote[] items = new RosterNote[nl.Count];
            int i = 0;
            foreach (Element e in nl)
            {
                items[i] = (RosterNote)e;
                i++;
            }
            return items;
        }
    }
}
