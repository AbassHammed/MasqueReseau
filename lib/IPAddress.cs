using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Reseau.lib
{
    public class IPAddressCalculator
    {
        private IPAddress Ip { get; set; }
        private IPAddress Mask { get; set; }
        public string className { get; private set; } = string.Empty;
        public string BroadAdr { get; private set; } = string.Empty;
        public string firstAddr { get; private set; } = string.Empty;
        public string lastAdr { get; private set; } = string.Empty;
        public string NbrIp { get; private set; } = string.Empty;
        public string NetAddr { get; private set; } = string.Empty;
        public string NbrHost { get; private set; } = string.Empty;
        public string wildCard { get; private set; } = string.Empty;
        public string ipType { get; private set; } = string.Empty;

        public IPAddressCalculator(string ip, string mask)
        {
            Ip = IPAddress.Parse(ip);
            Mask = IPAddress.Parse(mask);
        }

        private void GetNetworkAddress()
        {
            byte[] ipBytes = Ip.GetAddressBytes();
            byte[] maskBytes = Mask.GetAddressBytes();
            byte[] networkBytes = new byte[ipBytes.Length];

            for (int i = 0; i < ipBytes.Length; i++)
                networkBytes[i] = (byte)(ipBytes[i] & maskBytes[i]);

            NetAddr = new IPAddress(networkBytes).ToString();
        }

        private void GetBroadcastAddress()
        {
            byte[] ipBytes = Ip.GetAddressBytes();
            byte[] maskBytes = Mask.GetAddressBytes();
            byte[] broadcastBytes = new byte[ipBytes.Length];

            for (int i = 0; i < ipBytes.Length; i++)
                broadcastBytes[i] = (byte)(ipBytes[i] | ~maskBytes[i]);

            BroadAdr = new IPAddress(broadcastBytes).ToString();
        }

        private void GetIPAddressClass()
        {
            byte firstOctet = Ip.GetAddressBytes()[0];
            className = firstOctet switch
            {
                <= 127 => "A",
                <= 191 => "B",
                <= 223 => "C",
                <= 239 => "D",
                _ => "E",
            };

        }
    }
}
