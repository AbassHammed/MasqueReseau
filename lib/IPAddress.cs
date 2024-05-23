using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseau.lib
{
    public class IPAddress
    {
        private string Ip { get; set; }
        private string Mask { get; set; }
        public string? classGrp { get; private set; }
        public string? addrNet { get; private set; }
        public string? addrBroad { get; private set; }
        public string? firstAddr { get; private set; }
        public string? lastAddr { get; private set; }
        public string? NbrIp { get; private set; }
        public string? NbrHost { get; private set; }
        public string? wildCard { get; private set; }
        public string? ipType { get; private set; }
        
        public IPAddress(string ip, string mask)
        {
            Ip = ip;
            Mask = mask;
        }
    }
}
