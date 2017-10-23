using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace VisualClient
{
    class Utilities
    {
        
        public string[] Ipv4ToIpv6(string address)
        {
            string[] payload = new string[3];
            try
            {
                IPAddress.TryParse(address, out IPAddress ipv4);
                if (ipv4.IsIPv4MappedToIPv6)
                {
                    IPAddress ipv6 = ipv4.MapToIPv6();
                    payload[0] = ipv6.ToString();
                    payload[1] = "1";
                    payload[2] = null;
                }
                else
                {
                    payload[0] = null;
                    payload[1] = "-1";
                    payload[2] = "Conversion Failed";
                }
                return payload;
            }
            catch (Exception e)
            {
                payload[0] = null;
                payload[1] = "-2";
                payload[2] = e.Message;
                return payload;
            }
        }
        public string Ipv6ToIpv4(string address)
        {
            try
            {
                IPAddress.TryParse(address, out IPAddress ipv6);
                if (ipv6.IsIPv4MappedToIPv6)
                {
                    IPAddress ipv4 = ipv6.MapToIPv4();
                    return ipv4.ToString();
                }
                return "Conversion Failed";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string FqdnToIpv4(string fqdn)
        {
            try
            {
                IPHostEntry hostEntry = Dns.GetHostEntry(fqdn);
                return hostEntry.AddressList[0].ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public IPAddress FqdnToIpv6(string fqdn)
        {
            throw new NotImplementedException();
        }
        public string Ipv4ToFqdn(string address)
        {
            try
            {
                IPHostEntry hostEntry = Dns.GetHostEntry(address);
                return hostEntry.HostName;
            }
            catch (Exception e)
            {
                return e.Message;
            }
            
        }
        public string Ipv6ToFqdn(string address)
        {
            IPHostEntry hostEntry = Dns.GetHostEntry(address);
            return hostEntry.HostName;
        }
    }
}
