

using System;
using Xmpp.Xml.Dom;

namespace Xmpp.protocol.time
{
    public class Time : Element
    {
        /// <summary>
        /// XEP-0202: Entity Time
        /// </summary>
        public Time()
        {
            TagName = "time";
            Namespace = Uri.URN_TIME;
        }

        /// <summary>
        /// Gets or sets the UTC offset.
        /// </summary>
        /// <value>The UTC offset.</value>
        public TimeSpan UtcOffset
        {
            get
            {
                var tzo = GetTag("tzo");
                if (tzo == null)
                    return TimeSpan.Zero;

                /* .NET is not able to parse the following format: "-03:30"
                    so we append the minutes and .NET is happy.
                    
                    -10:00 len:6
                     10:00 len:5
                 */
                if (tzo.Length == 5 || tzo.Length == 6)
                    tzo += ":00";

                return TimeSpan.Parse(tzo);
            }
            set { SetTag("tzo", FormatOffset(value)); }
        }

        /// <summary>
        /// Gets or sets the date time.
        /// </summary>
        /// <value>The date time.</value>
        public DateTime DateTime
        {
            get { return  Util.Time.ISO_8601Date(GetTag("utc")); }
            set { SetTag("utc", Util.Time.ISO_8601Date(value)); }
        }

        /// <summary>
        /// Sets the utc offset and time automatically.
        /// </summary>
        public void SetDateTimeNow()
        {
            UtcOffset = Util.Time.UtcOffset();
            DateTime = DateTime.Now;
        }

        static string FormatOffset(TimeSpan ts)
        {
            return String.Format("{0:00}:{1:00}", ts.Hours, Math.Abs(ts.Minutes));
        }
    }
}