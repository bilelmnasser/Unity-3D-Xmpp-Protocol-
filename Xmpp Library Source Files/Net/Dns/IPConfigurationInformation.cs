

using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace Xmpp.Net.Dns
{
    /// <summary>
    /// Summary description for IPConfigurationInformation.
    /// </summary>
    public class IPConfigurationInformation
    {
        public static List<IPAddress> DnsServers
        {
            get
            {
                var dnsServers = new List<IPAddress>();
                var interfaces = NetworkInterface.GetAllNetworkInterfaces();
                foreach (var eth in interfaces)
                {
                    if (eth.OperationalStatus == OperationalStatus.Up)
                    {
                        var ethProperties = eth.GetIPProperties();
                        var dnsHosts = ethProperties.DnsAddresses;
                        dnsServers.AddRange(dnsHosts);
                    }
                }
                return dnsServers;
            }
        }
    }
}