namespace Reseau.lib
{
    public class Utils
    {
        public static bool ChampsDansLaLimite(int limite, params TextBox[] champs)
        {
            foreach (var champ in champs)
                if (string.IsNullOrWhiteSpace(champ.Text) || !int.TryParse(champ.Text, out int valeur) || valeur < 0 || valeur > limite)
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
                if (string.IsNullOrWhiteSpace(champ.Text) || !EstBinaire(champ.Text))
                    return false;
            return true;
        }

        public static bool ChampsHexadecimaux(params TextBox[] champs)
        {
            foreach (var champ in champs)
                if (string.IsNullOrWhiteSpace(champ.Text) || !int.TryParse(champ.Text, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out _))
                    return false;
            return true;
        }
        public static string BinaryToHex(params TextBox[] champs)
        {
            string[] hexValues = new string[champs.Length];
            for (int i = 0; i < champs.Length; i++)
                if (int.TryParse(champs[i].Text, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out int decimalValue))
                    hexValues[i] = Convert.ToString(decimalValue, 16).PadLeft(2, '0');

            return string.Join(".", hexValues);
        }

        public static string HexToBinary(params TextBox[] champs)
        {
            string[] binaryValues = new string[champs.Length];
            for (int i = 0; i < champs.Length; i++)
                if (int.TryParse(champs[i].Text, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out int decimalValue))
                    binaryValues[i] = Convert.ToString(decimalValue, 2).PadLeft(8, '0');

            return string.Join(".", binaryValues);
        }

        public static string DecimalToBinary(params TextBox[] champs)
        {
            string[] binaryValues = new string[champs.Length];
            for (int i = 0; i < champs.Length; i++)
                if (int.TryParse(champs[i].Text, out int decimalValue))
                    binaryValues[i] = Convert.ToString(decimalValue, 2).PadLeft(8, '0');

            return string.Join(".", binaryValues);
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

        public static void adjustIpDec(int min, int max, params TextBox[] champs)
        {
            foreach (var champ in champs)
            {
                if (int.TryParse(champ.Text, out int valeur))
                {
                    if (valeur < min)
                        champ.Text = min.ToString();
                    else if (valeur > max)
                        champ.Text = max.ToString();
                }
            }
        }

        // public static void adjustMaskDec(params TextBox[] champs)
        // {
        //     int[] validMaskValues = [0, 128, 192, 224, 240, 248, 252, 254, 255];

        //     int previousValue = 255;

        //     foreach (var champ in champs)
        //     {
        //         if (int.TryParse(champ.Text, out int currentValue) && validMaskValues.Contains(currentValue))
        //         {
        //             if (currentValue <= previousValue)
        //                 previousValue = currentValue;
        //             else if (currentValue > previousValue)
        //                 champ.Text = 0.ToString();
        //         }
        //         else
        //             champ.Text = previousValue.ToString();
        //     }
        // }
        public static void adjustMaskDec(params TextBox[] champs)
        {
            int[] validMaskValues = [0, 128, 192, 224, 240, 248, 252, 254, 255];

            int previousValue = 255;

            for (int i = 0; i < champs.Length; i++)
            {
                if (int.TryParse(champs[i].Text, out int currentValue) && validMaskValues.Contains(currentValue))
                {
                    if (currentValue <= previousValue)
                    {
                        if (previousValue != 255 && currentValue != 0)
                            champs[i].Text = "0";
                        else
                            previousValue = currentValue;
                    }
                    else
                        champs[i].Text = "0";
                }
            }

            // // Assurer que toutes les valeurs après une valeur différente de 255 sont 0
            // bool foundNon255 = false;
            // for (int i = 0; i < champs.Length; i++)
            // {
            //     if (int.TryParse(champs[i].Text, out int currentValue))
            //     {
            //         if (currentValue != 255)
            //             foundNon255 = true;

            //         if (foundNon255 && currentValue != 0)
            //             champs[i].Text = "0";
            //     }
            // }
        }





    }
}
