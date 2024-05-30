namespace Reseau.lib
{
    public class Utils
    {
        /// <summary>
        /// Vérifie si tous les champs textuels contiennent des valeurs entières valides dans la limite spécifiée.
        /// </summary>
        /// <param name="limite">La valeur limite pour les nombres entiers dans les champs textuels.</param>
        /// <param name="champs">Les champs TextBox à vérifier.</param>
        /// <returns>True si tous les champs sont dans la limite, sinon False.</returns>
        public static bool ChampsDansLaLimite(int limite, params TextBox[] champs)
        {
            foreach (var champ in champs)
                if (string.IsNullOrWhiteSpace(champ.Text) || !int.TryParse(champ.Text, out int valeur) || valeur < 0 || valeur > limite) // Verifier si le text est vide ou si la valeur n'est pas un entier valide ou si la valeur n'est pas dans la limite
                    return false;

            return true;
        }

        /// <summary>
        /// Vérifie si au moins un des champs textuels est vide.
        /// </summary>
        /// <param name="champs">Les champs TextBox à vérifier.</param>
        /// <returns>True si au moins un champ est vide, sinon False.</returns>
        public static bool IsEmpty(params TextBox[] champs)
        {
            foreach (var champ in champs)
                if (string.IsNullOrWhiteSpace(champ.Text))
                    return true;

            return false;
        }

        /// <summary>
        /// Efface le texte de tous les champs textuels fournis.
        /// </summary>
        /// <param name="champs">Les champs TextBox à vider.</param>
        public static void Vider(params TextBox[] champs)
        {
            foreach (var champ in champs)
                champ.Clear();
        }

        /// <summary>
        /// Vérifie si tous les champs contiennent des valeurs hexadécimales valides.
        /// </summary>
        /// <param name="champs">Les champs TextBox à vérifier.</param>
        /// <returns>True si tous les champs contiennent des valeurs hexadécimales valides, sinon False.</returns>
        public static bool ChampsHexadecimaux(params TextBox[] champs)
        {
            foreach (var champ in champs)
                if (string.IsNullOrWhiteSpace(champ.Text) || !int.TryParse(champ.Text, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out _))
                    return false;
            return true;
        }

        /// <summary>
        /// Convertit les valeurs binaires de tous les champs en valeurs hexadécimales.
        /// </summary>
        /// <param name="champs">Les champs TextBox contenant des valeurs binaires.</param>
        /// <returns>Une chaîne représentant les valeurs hexadécimales séparées par des points.</returns>
        public static string BinaryToHex(params TextBox[] champs)
        {
            string[] hexValues = new string[champs.Length];
            for (int i = 0; i < champs.Length; i++)
                hexValues[i] = Convert.ToInt32(champs[i].Text, 2).ToString("X");

            return string.Join(".", hexValues);
        }

        /// <summary>
        /// Convertit les valeurs hexadécimales de tous les champs en valeurs binaires.
        /// </summary>
        /// <param name="champs">Les champs TextBox contenant des valeurs hexadécimales.</param>
        /// <returns>Une chaîne représentant les valeurs binaires séparées par des points.</returns>
        public static string HexToBinary(params TextBox[] champs)
        {
            string[] binaryValues = new string[champs.Length];
            for (int i = 0; i < champs.Length; i++)
            {
                // Convertit la valeur hexadécimale en binaire et la formate pour être affichée avec au moins 8 chiffres, ajoutant des zéros à gauche si nécessaire
                binaryValues[i] = Convert.ToString(Convert.ToInt32(champs[i].Text, 16), 2).PadLeft(8, '0');
            }

            return string.Join(".", binaryValues);
        }

        /// <summary>
        /// Convertit les valeurs décimales de tous les champs en valeurs binaires, avec chaque valeur binaire formatée pour avoir au moins 8 chiffres.
        /// </summary>
        /// <param name="champs">Les champs TextBox contenant des valeurs décimales.</param>
        /// <returns>Une chaîne représentant les valeurs binaires séparées par des points.</returns>
        public static string DecimalToBinary(params TextBox[] champs)
        {
            string[] binaryValues = new string[champs.Length];
            for (int i = 0; i < champs.Length; i++)
            {
                // Tente de convertir le texte du champ en un entier
                if (int.TryParse(champs[i].Text, out int decimalValue))
                {
                    // Convertit la valeur décimale en binaire et la formate pour être affichée avec au moins 8 chiffres, ajoutant des zéros à gauche si nécessaire
                    binaryValues[i] = Convert.ToString(decimalValue, 2).PadLeft(8, '0');
                }
            }

            // Rejoint les valeurs binaires en une seule chaîne, séparées par des points
            return string.Join(".", binaryValues);
        }

        /// <summary>
        /// Convertit les valeurs binaires de tous les champs en valeurs décimales.
        /// </summary>
        /// <param name="champs">Les champs TextBox contenant des valeurs binaires.</param>
        /// <returns>Une chaîne représentant les valeurs décimales séparées par des points.</returns>
        public static string BinaryToDecimal(params TextBox[] champs)
        {
            string[] decimalValues = new string[champs.Length];
            for (int i = 0; i < champs.Length; i++)
            {
                // Tente de convertir le texte du champ, qui est supposé être en format binaire, en un entier
                if (int.TryParse(champs[i].Text, out int binaryValue))
                {
                    // Convertit la valeur binaire en décimal
                    decimalValues[i] = Convert.ToInt32(champs[i].Text, 2).ToString();
                }
            }

            // Concaténation des valeurs décimales en une seule chaîne, séparées par des points
            return string.Join(".", decimalValues);
        }

        /// <summary>
        /// Convertit les valeurs hexadécimales de tous les champs en valeurs décimales.
        /// </summary>
        /// <param name="champs">Les champs TextBox contenant des valeurs hexadécimales.</param>
        /// <returns>Une chaîne représentant les valeurs décimales séparées par des points.</returns>
        public static string HexToDecimal(params TextBox[] champs)
        {
            string[] decimalValues = new string[champs.Length];
            for (int i = 0; i < champs.Length; i++)
            {
                // Convertit la valeur hexadécimale en décimale. Utilise la base 16 pour la conversion.
                decimalValues[i] = Convert.ToInt32(champs[i].Text, 16).ToString();
            }

            // concatène les valeurs décimales en une seule chaîne, séparées par des points.
            return string.Join(".", decimalValues);
        }

        /// <summary>
        /// Convertit les valeurs décimales de tous les champs en valeurs hexadécimales.
        /// </summary>
        /// <param name="champs">Les champs TextBox contenant des valeurs décimales.</param>
        /// <returns>Une chaîne représentant les valeurs hexadécimales séparées par des points.</returns>
        public static string DecimalToHex(params TextBox[] champs)
        {
            string[] hexValues = new string[champs.Length];
            for (int i = 0; i < champs.Length; i++)
            {
                // Tente de convertir le texte du champ en un entier décimal
                if (int.TryParse(champs[i].Text, out int decimalValue))
                {
                    // Convertit la valeur décimale en hexadécimale, formatée en utilisant "X" pour une sortie en majuscules
                    hexValues[i] = decimalValue.ToString("X");
                }
            }

            // Rejoint les valeurs hexadécimales en une seule chaîne, séparées par des points.
            return string.Join(".", hexValues);
        }

        /// <summary>
        /// Convertit un masque CIDR en un masque binaire
        /// </summary>
        /// <param name="cidr"> Le masque CIDR </param>
        /// <returns></returns>
        public static string CidrToDecimal(string cidr)
        {
            // Convertit la chaîne cidr en un entier qui représente la longueur du préfixe
            int prefixLength = int.Parse(cidr);

            // Crée un masque en déplaçant des 1 dans un nombre de 32 bits de gauche à droite
            // basé sur la longueur du préfixe. Par exemple, si prefixLength est 24,
            // alors le masque sera 11111111.11111111.11111111.00000000 en binaire
            uint mask = uint.MaxValue << (32 - prefixLength);

            // Crée un tableau pour stocker les parties décimales du masque
            string[] decimalMask = new string[4];
            for (int i = 0; i < 4; i++)
            {
                // Décale le masque de 24, 16, 8 et 0 bits vers la droite (pour chaque octet) et 
                // applique un ET avec 0xFF pour obtenir seulement la dernière partie (dernier octet).
                // Puis convertit cet octet en sa représentation décimale et le stocke dans le tableau.
                decimalMask[i] = ((mask >> (24 - (i * 8))) & 0xFF).ToString();
            }

            // Joint les quatre parties décimales en une seule chaîne, séparées par des points
            // et retourne cette chaîne. C'est la représentation décimale du masque CIDR.
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

        public static bool adjustTextBoxValuesBaseOnLimits(int min, int max, params TextBox[] champs)
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
                else
                    return false;
            }
            return true;
        }

        public static void adjustMaskDec(params TextBox[] champs)
        {
            int[] validMaskValues = [0, 128, 192, 224, 240, 248, 252, 254, 255];

            int previousValue = 255;

            for (int i = 0; i < champs.Length; i++)
            {
                if (int.TryParse(champs[i].Text, out int currentValue))
                {
                    if (validMaskValues.Contains(currentValue))
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
                    else
                        champs[i].Text = previousValue.ToString();
                }
            }
        }
    }
}
