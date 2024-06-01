using System.Net;

namespace Reseau.lib
{
    /// <summary>
    /// Fournit des méthodes pour calculer divers détails du réseau tels que l'adresse de réseau,
    /// l'adresse de diffusion, la classe de l'IP, et plus, en fonction de l'adresse IP et du masque de sous-réseau fournis.
    /// </summary>
    /// <param name="ip"></param>
    /// <param name="mask"></param>
    public class IPAddressCalculator(string ip, string mask)
    {
        private IPAddress Ip { get; set; } = IPAddress.Parse(ip);
        private IPAddress Mask { get; set; } = IPAddress.Parse(mask);

        // Dictionnaire liant des plages spécifiques d'adresses IP à leurs descriptions.
        private static readonly Dictionary<Func<byte[], bool>, string> ipRanges = new()
        {
            // Initialisations avec des conditions spécifiques pour chaque plage d'adresse IP
            { ipBytes => ipBytes[0] == 0, "\"Ce\" réseau" },
            { ipBytes => ipBytes[0] == 10, "Réseaux à usage privé" },
            { ipBytes => ipBytes[0] == 127, "Bouclage" },
            { ipBytes => ipBytes[0] == 169 && ipBytes[1] == 254, "Lien local" },
            { ipBytes => ipBytes[0] == 172 && ipBytes[1] >= 16 && ipBytes[1] <= 31, "Réseaux à usage privé" },
            { ipBytes => ipBytes[0] == 192 && ipBytes[1] == 0 && ipBytes[2] == 0, "Attributions de protocole IETF" },
            { ipBytes => ipBytes[0] == 192 && ipBytes[1] == 0 && ipBytes[2] == 2, "TEST-NET-1" },
            { ipBytes => ipBytes[0] == 192 && ipBytes[1] == 88 && ipBytes[2] == 99, "6to4 Relay Anycast" },
            { ipBytes => ipBytes[0] == 192 && ipBytes[1] == 168, "Réseaux à usage privé" },
            { ipBytes => ipBytes[0] == 198 && ipBytes[1] >= 18 && ipBytes[1] <= 19, "Test d'interconnexion de dispositifs réseau" },
            { ipBytes => ipBytes[0] == 198 && ipBytes[1] == 51 && ipBytes[2] == 100, "TEST-NET-2" },
            { ipBytes => ipBytes[0] == 203 && ipBytes[1] == 0 && ipBytes[2] == 113, "TEST-NET-3" },
            { ipBytes => ipBytes[0] >= 224 && ipBytes[0] <= 239, "Multidiffusion" },
            { ipBytes => ipBytes[0] >= 240 && ipBytes[0] <= 255, "Réservé pour un usage futur" },
            { ipBytes => ipBytes[0] == 255 && ipBytes[1] == 255 && ipBytes[2] == 255 && ipBytes[3] == 255, "Diffusion limitée" }
        };

        /// <summary>
        /// Calcule et retourne l'adresse de réseau dérivée de l'adresse IP et du masque de sous-réseau.
        /// </summary>
        /// <returns>Adresse de réseau sous forme de chaîne.</returns>
        public string GetNetworkAddress()
        {
            byte[] ipBytes = Ip.GetAddressBytes();
            byte[] maskBytes = Mask.GetAddressBytes();
            byte[] networkBytes = new byte[ipBytes.Length];

            for (int i = 0; i < ipBytes.Length; i++)
                networkBytes[i] = (byte)(ipBytes[i] & maskBytes[i]);

            return new IPAddress(networkBytes).ToString();
        }

        /// <summary>
        /// Calcule et retourne l'adresse de diffusion basée sur l'adresse IP et le masque de sous-réseau.
        /// </summary>
        /// <returns>Adresse de diffusion sous forme de chaîne.</returns>
        public string GetBroadcastAddress()
        {
            byte[] ipBytes = Ip.GetAddressBytes();
            byte[] maskBytes = Mask.GetAddressBytes();
            byte[] broadcastBytes = new byte[ipBytes.Length];

            for (int i = 0; i < ipBytes.Length; i++)
                broadcastBytes[i] = (byte)(ipBytes[i] | ~maskBytes[i]);

            return new IPAddress(broadcastBytes).ToString();
        }

        /// <summary>
        /// Détermine la classe de l'adresse IP basée sur le premier octet.
        /// </summary>
        /// <returns>La classe de l'adresse IP (A, B, C, D, ou E).</returns>
        public string GetIPAddressClass()
        {
            byte firstOctet = Ip.GetAddressBytes()[0];
            return firstOctet switch
            {
                <= 127 => "A",
                <= 191 => "B",
                <= 223 => "C",
                <= 239 => "D",
                _ => "E",
            };

        }

        /// <summary>
        /// Identifie le type d'adresse IP basé sur des plages prédéfinies.
        /// </summary>
        /// <returns>Description du type d'adresse IP (privé, public, etc.).</returns>
        public string GetIPAddressType()
        {
            byte[] ipBytes = Ip.GetAddressBytes();
            foreach (var range in ipRanges)
                if (range.Key(ipBytes))
                    return range.Value;

            return "Public";
        }

        /// <summary>
        /// Calcule la première adresse IP utilisable dans le sous-réseau.
        /// </summary>
        /// <returns>La première adresse IP utilisable.</returns>
        public string GetFirstIPAddress()
        {
            if (Mask.ToString() == "255.255.255.255" || Mask.ToString() == "255.255.255.254")
                return "N/A";

            byte[] networkBytes = IPAddress.Parse(GetNetworkAddress()).GetAddressBytes();
            if (networkBytes[3] < 255)
                networkBytes[3] += 1;

            return new IPAddress(networkBytes).ToString();
        }


        /// <summary>
        /// Calcule la dernière adresse IP utilisable dans le sous-réseau.
        /// </summary>
        /// <returns>La dernière adresse IP utilisable.</returns>
        public string GetLastIPAddress()
        {
            if (Mask.ToString() == "255.255.255.255" || Mask.ToString() == "255.255.255.254")
                return "N/A";

            byte[] broadcastBytes = IPAddress.Parse(GetBroadcastAddress()).GetAddressBytes();
            if (broadcastBytes[3] > 0)
                broadcastBytes[3] -= 1;

            return new IPAddress(broadcastBytes).ToString();
        }

        /// <summary>
        /// Calcule le nombre total d'adresses IP dans le sous-réseau.
        /// </summary>
        /// <returns>Nombre total d'adresses IP sous forme de chaîne.</returns>
        public string GetNumberOfIPAddresses()
        {
            int bits = CountZeroBitsInMask(Mask);
            return Math.Pow(2, bits).ToString();
        }

        /// <summary>
        /// Calcule le nombre d'hôtes utilisables dans le sous-réseau.
        /// </summary>
        /// <returns>Nombre d'hôtes utilisables sous forme de chaîne.</returns>
        public string GetNumberOfHosts()
        {
            int totalIPs = (int)Math.Pow(2, CountZeroBitsInMask(Mask));
            return (totalIPs > 2) ? (totalIPs - 2).ToString() : "0";
        }


        private int CountZeroBitsInMask(IPAddress mask)
        {
            byte[] maskBytes = mask.GetAddressBytes();
            int zeroBits = 0;

            foreach (byte b in maskBytes)
                for (int i = 7; i >= 0; i--)
                    if ((b & (1 << i)) == 0)
                        zeroBits++;

            return zeroBits;
        }

        /// <summary>
        /// Calcule et retourne le masque inverse (wildcard) pour le masque de sous-réseau.
        /// </summary>
        /// <returns>Masque inverse sous forme de chaîne.</returns>
        public string GetWildcardMask()
        {
            byte[] maskBytes = Mask.GetAddressBytes();
            byte[] wildcardBytes = new byte[maskBytes.Length];

            for (int i = 0; i < maskBytes.Length; i++)
                wildcardBytes[i] = (byte)~maskBytes[i];

            return new IPAddress(wildcardBytes).ToString();
        }
    }
}
