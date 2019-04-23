using System;

namespace Xmpp.protocol.iq.register
{
    public delegate void RegisterEventHandler(object sender, RegisterEventArgs args);

    public class RegisterEventArgs
    {
        public RegisterEventArgs()
        {
        }
        
        public RegisterEventArgs(Register reg)
        {
            m_Register = reg;
        }
        
        // by default we register automatically
        private bool						m_Auto			= true;
        private Register                    m_Register;

        /// <summary>
        /// Set Auto to true if the library should register automatically
        /// Set it to false if you want to fill out the registration fields manual
        /// </summary>
        public bool Auto
        {
            get { return m_Auto; }
            set { m_Auto = value; }
        }

        public Register Register
        {
            get { return m_Register; }
            set { m_Register = value; }
        }

    }
}