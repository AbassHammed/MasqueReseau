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

            string[] decimalMask = new string[4];
            for (int i = 0; i < 4; i++)
            {
                // Décale le masque de 24, 16, 8 et 0 bits vers la droite (pour chaque octet) et 
                // applique un ET avec 0xFF(255) pour obtenir seulement la dernière partie (dernier octet).
                // Puis convertit cet octet en sa représentation décimale et le stocke dans le tableau.
                decimalMask[i] = ((mask >> (24 - (i * 8))) & 0xFF).ToString();
            }

            return string.Join(".", decimalMask);
        }


        /// <summary>
        /// Convertit un préfixe CIDR en une représentation binaire de son masque de sous-réseau.
        /// </summary>
        /// <param name="cidr">Le préfixe CIDR, indiquant la longueur du préfixe de masque de sous-réseau.</param>
        /// <returns>Une chaîne représentant le masque de sous-réseau en notation binaire.</returns>
        public static string CidrToBinary(string cidr)
        {
            // Convertit la chaîne CIDR en un entier pour déterminer la longueur du préfixe du masque de sous-réseau.
            int prefixLength = int.Parse(cidr);

            // Initialise un tableau pour stocker les quatre octets binaires du masque.
            string[] binaryMask = new string[4];

            // Un compteur pour suivre le nombre total de bits à 1 ajoutés au masque.
            int totalBits = 0;

            // Boucle sur chaque élément du tableau (chaque octet du masque).
            for (int i = 0; i < 4; i++)
            {
                // Crée une chaîne vide pour construire l'octet binaire.
                string binaryOctet = "";

                // Construit chaque octet avec 8 bits.
                for (int j = 0; j < 8; j++)
                {
                    // Ajoute '1' au masque tant que le total de bits à 1 n'atteint pas la longueur du préfixe.
                    if (totalBits < prefixLength)
                    {
                        binaryOctet += "1";
                        totalBits++;
                    }
                    else
                        // Remplit le reste de l'octet avec des '0' une fois la longueur du préfixe atteinte.
                        binaryOctet += "0";
                }

                binaryMask[i] = binaryOctet;
            }

            return string.Join(".", binaryMask);
        }


        /// <summary>
        /// Convertit un masque de réseau binaire en notation CIDR.
        /// </summary>
        /// <param name="binaryMask">Le masque de réseau en notation binaire, séparé par des points.</param>
        /// <returns>CIDR correspondant au masque binaire.</returns>
        public static string BinaryToCidr(string binaryMask)
        {
            var parts = binaryMask.Split('.');
            int cidr = 0;

            // Parcourt chaque partie (octet) du masque binaire.
            foreach (string part in parts)
            {
                // Pour chaque caractère dans la partie de l'octet (devrait être composé de '0' ou de '1').
                foreach (char bit in part)
                    // Ajoute 1 au compteur CIDR pour chaque bit à '1'.
                    if (bit == '1')
                        cidr++;
            }

            return cidr.ToString();
        }

        /// <summary>
        /// Convertit un masque de sous-réseau décimal en notation CIDR.
        /// </summary>
        /// <param name="decimalMask">Le masque de réseau en notation décimale, séparé par des points.</param>
        /// <returns>CIDR correspondant au masque décimal.</returns>
        public static string DecimalToCidr(string decimalMask)
        {
            var parts = decimalMask.Split('.');
            int prefixLength = 0;

            // Parcourt chaque partie (octet) du masque décimal.
            foreach (string part in parts)
            {
                // Convertit chaque partie décimale en un entier.
                int decimalValue = int.Parse(part);

                // Convertit la valeur décimale en une chaîne binaire.
                string binaryRepresentation = Convert.ToString(decimalValue, 2);

                // Compte les '1' dans la représentation binaire de l'octet.
                foreach (char bit in binaryRepresentation)
                    if (bit == '1')
                        prefixLength++;
            }

            return prefixLength.ToString();
        }


        /// <summary>
        /// Ajuste les valeurs dans un ensemble de TextBox pour s'assurer qu'elles respectent les limites spécifiées.
        /// Si une valeur n'est pas un entier valide ou ne respecte pas les limites, elle est ajustée au minimum ou au maximum.
        /// </summary>
        /// <param name="min">La valeur minimale autorisée.</param>
        /// <param name="max">La valeur maximale autorisée.</param>
        /// <param name="champs">Un tableau de TextBox dont les valeurs doivent être vérifiées et ajustées.</param>
        /// <returns>True si toutes les valeurs ont été ajustées avec succès ou étaient déjà valides, False si au moins une valeur n'était pas convertible en entier.</returns>
        public static bool adjustTextBoxValuesBaseOnLimits(int min, int max, params TextBox[] champs)
        {
            foreach (var champ in champs)
            {
                // Essaie de convertir le texte du champ en un entier.
                if (int.TryParse(champ.Text, out int valeur))
                {
                    // Si la valeur est inférieure au minimum, ajuste-la au minimum.
                    if (valeur < min)
                        champ.Text = min.ToString();
                    // Si la valeur est supérieure au maximum, ajuste-la au maximum.
                    else if (valeur > max)
                        champ.Text = max.ToString();
                }
                else
                    // Si la conversion échoue, renvoie false, indiquant une valeur invalide.
                    return false;
            }
            // Renvoie true si toutes les valeurs ont été ajustées avec succès ou étaient déjà valides.
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
