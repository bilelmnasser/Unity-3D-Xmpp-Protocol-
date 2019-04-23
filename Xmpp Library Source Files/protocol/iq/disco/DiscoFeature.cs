using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.iq.disco
{
	/// <summary>
	/// Disco feature
	/// </summary>
	/// <remarks>
	/// see: http://www.jabber.org/registrar/disco-features.html
	/// </remarks>
	public class DiscoFeature : Element
	{
        /*
        <iq type='result'
            from='plays.shakespeare.lit'
            to='romeo@montague.net/orchard'
            id='info1'>
        <query xmlns='http://jabber.org/protocol/disco#info'>
            <identity
                category='conference'
                type='text'
                name='Play-Specific Chatrooms'/>
            <identity
                category='directory'
                type='chatroom'
                name='Play-Specific Chatrooms'/>
            <feature var='http://jabber.org/protocol/disco#info'/>
            <feature var='http://jabber.org/protocol/disco#items'/>
            <feature var='http://jabber.org/protocol/muc'/>
            <feature var='jabber:iq:register'/>
            <feature var='jabber:iq:search'/>
            <feature var='jabber:iq:time'/>
            <feature var='jabber:iq:version'/>
        </query>
        </iq>
        */
        #region << Constructors >>
        public DiscoFeature()
		{
			this.TagName	= "feature";
			this.Namespace	= Uri.DISCO_INFO;
		}

		public DiscoFeature(string var) : this()
		{
			Var = var;
        }
        #endregion

        /// <summary>
		/// feature name or namespace
		/// </summary>
		public string Var
		{
			get { return GetAttribute("var"); }
			set { SetAttribute("var", value); }
		}
	}
}
