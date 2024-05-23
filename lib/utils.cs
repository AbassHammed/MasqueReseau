namespace Reseau.lib
{
    public class Utils
    {

        public static bool ChampsEntiers(params TextBox[] champs)
        {
            foreach (var champ in champs)
                if (!int.TryParse(champ.Text, out _))
                    return false;
            return true;
        }

        public static bool ChampsRemplis(params TextBox[] champs)
        {
            foreach (var champ in champs)
                if (string.IsNullOrWhiteSpace(champ.Text))
                    return false;
            return true;
        }

        public static bool ChampsDansLaLimite(int limite, params TextBox[] champs)
        {
            foreach (var champ in champs)
                if (!int.TryParse(champ.Text, out int valeur) || valeur < 0 || valeur > limite)
                    return false;
            return true;
        }

        public static void Vider(params TextBox[] champs)
        {
            foreach (var champ in champs)
                champ.Clear();
        }

        private static bool EstBinaire(string text)
        {
            return text.All(c => c == '0' || c == '1');
        }


        public static bool ChampsBinaires(params TextBox[] champs)
        {
            foreach (var champ in champs)
                if (!EstBinaire(champ.Text))
                    return false;
            return true;
        }

        public static bool ChampsHexadecimaux(params TextBox[] champs)
        {
            foreach (var champ in champs)
                if (!int.TryParse(champ.Text, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out _))
                    return false;
            return true;
        }
        public static string BinaryToHex(string binary)
        {
            int decimalValue = Convert.ToInt32(binary, 2);
            return decimalValue.ToString("X");
        }

        public static string HexToBinary(string hex)
        {
            int decimalValue = Convert.ToInt32(hex, 16);
            return Convert.ToString(decimalValue, 2).PadLeft(8, '0');
        }

        public static string DecimalToBinary(string decimalNumberStr)
        {
            int decimalNumber = int.Parse(decimalNumberStr);
            return Convert.ToString(decimalNumber, 2).PadLeft(8, '0');
        }

        public static string BinaryToDecimal(string binary)
        {
            int decimalValue = Convert.ToInt32(binary, 2);
            return decimalValue.ToString();
        }

        public static string HexToDecimal(string hex)
        {
            int decimalValue = Convert.ToInt32(hex, 16);
            return decimalValue.ToString();
        }

        public static string DecimalToHex(string decimalNumberStr)
        {
            int decimalNumber = int.Parse(decimalNumberStr);
            return decimalNumber.ToString("X");
        }

        public static string CidrToDecimal(string cidr)
        {
            int prefixLength = int.Parse(cidr);

            uint mask = uint.MaxValue << (32 - prefixLength);

            string[] decimalMask = new string[4];
            for (int i = 0; i < 4; i++)
                decimalMask[i] = ((mask >> (24 - (i * 8))) & 0xFF).ToString();

            return string.Join(".", decimalMask);
        }

        public static string CidrToBinary(string cidr)
        {
            int prefixLength = int.Parse(cidr);

            uint mask = uint.MaxValue << (32 - prefixLength);

            string[] binaryMask = new string[4];
            for (int i = 0; i < 4; i++)
                binaryMask[i] = Convert.ToString((mask >> (24 - (i * 8))) & 0xFF, 2).PadLeft(8, '0');

            return string.Join(".", binaryMask);
        }

        public static string BinaryToCidr(string binaryMask)
        {
            var parts = binaryMask.Split('.');
            if (parts.Length != 4)
                throw new ArgumentException("Invalid binary mask format");

            uint mask = 0;
            for (int i = 0; i < 4; i++)
                mask |= Convert.ToUInt32(parts[i], 2) << (24 - (i * 8));

            int prefixLength = 0;
            while (mask > 0)
            {
                prefixLength += (int)(mask & 1);
                mask >>= 1;
            }

            return prefixLength.ToString();
        }

        public static string DecimalToCidr(string decimalMask)
        {
            var parts = decimalMask.Split('.');
            if (parts.Length != 4)
                throw new ArgumentException("Invalid decimal mask format");

            uint mask = 0;
            for (int i = 0; i < 4; i++)
                mask |= uint.Parse(parts[i]) << (24 - (i * 8));

            int prefixLength = 0;
            while (mask > 0)
            {
                prefixLength += (int)(mask & 1);
                mask >>= 1;
            }

            return prefixLength.ToString();
        }



    }
}
