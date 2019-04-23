

using System;
using System.Text;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.x.vcard_update
{
    /*
        <presence>
          <x xmlns='vcard-temp:x:update'>
            <photo/>
          </x>
        </presence>
    */
    public class VcardUpdate : Element
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="VcardUpdate"/> class.
        /// </summary>
        public VcardUpdate()
        {
            this.TagName    = "x";
            this.Namespace  = Uri.VCARD_UPDATE;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="VcardUpdate"/> class.
        /// </summary>
        /// <param name="photo">The photo.</param>
        public VcardUpdate(string photo) : this()
        {
            Photo = photo;
        }

        /// <summary>
        /// SHA1 hash of the avatar image data
        /// <para>if no image/avatar should be advertised, or other clients should be forced
        /// to remove the image set it to a empty string value ("")</para>
        /// <para>if this protocol is supported but you ae not ready o advertise a imaeg yet
        /// set teh value to null.</para>
        /// <para>Otherwise teh value must the SHA1 hash of the image data.</para>
        /// </summary>
        public string Photo
        {
            get { return GetTag("photo"); }
            set
            {
                if (value == null)
                    RemoveTag("photo");
                else
                    SetTag("photo", value);
            }
        }
    }
}
