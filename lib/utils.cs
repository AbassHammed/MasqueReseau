using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static bool ChampsRemplisEtEntiers(params TextBox[] champs)
        {
            return ChampsRemplis(champs) && ChampsEntiers(champs);
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


    }
}
