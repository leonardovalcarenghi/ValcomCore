using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValcomCore.ExtensionMethods.Strings
{
    public static class ChangeStringMethods
    {

        public static readonly string[] GRAMMATICAL_PREPOSITIONS = {
                "a", "à", "ao", "aos", "até", "afora",
                "com", "como", "contra", "conforme", "consoante",
                "da", "das", "de", "di", "do", "dos", "dum",  "desde", "desta", "durante", "daquilo",
                "e", "é", "exceto",
                "mediante","menos",
                "na", "no", "nos", "neste", "nisso", "naquele", "numa",
                "o",
                "pra", "pro" ,"para",
                "sem", "sob", "sobre","segundo",
                "trás",
                "visto"
        };


        /// <summary>
        /// 
        /// </summary>
        public static string CapitalizeWords(this string value) => CapitalizeWords(value, "");


        /// <summary>
        /// 
        /// </summary>
        public static string CapitalizeWords(this string value, params string[] ignore)
        {
            string[] words = value.Trim().ToLower().Split(' ');
            int totalWords = words.Length;
            value = string.Empty;
            foreach (string word in words)
            {
                if (string.IsNullOrEmpty(word)) { continue; }           
                if (ignore.Contains(word)) { value = string.Concat(value, word, " "); continue; }
                string firstLetter = word[0].ToString().ToUpper();
                string newWord = string.Concat(firstLetter, word.Substring(1));
                value = string.Concat(value, newWord, " ");
            }
            return value.Trim();
        }

        /// <summary>
        /// 
        /// </summary>
        public static string Reverse(this string value)
        {
            string result = string.Empty;
            for (int i = 1; i <= value.Length; i++) { result += value.Substring(value.Length - i, 1); }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        public static string RemoveAccentuation(this string value)
        {
            if (!value.HasContent()) { return ""; }

            string[] AAA = { "á", "à", "â", "ä", "ã" };
            string A = "a";

            string[] EEE = { "é", "è", "ê", "ë" };
            string E = "e";

            string[] III = { "í", "ì", "î", "ï" };
            string I = "i";

            string[] OOO = { "ó", "ò", "ô", "ö", "õ" };
            string O = "o";

            string[] UUU = { "ú", "ù", "û", "ü" };
            string U = "u";

            for (int i = 0; i < value.Length; i++)
            {
                string letter = value[i].ToString();
                bool isUpper = char.IsUpper(letter, 0);
                letter = letter.ToLower();

                // Letra A:
                if (AAA.Contains(letter)) { value = value.ReplaceAt(i, isUpper ? A.ToUpper() : A.ToLower()); continue; }

                // Letra E:
                if (EEE.Contains(letter)) { value = value.ReplaceAt(i, isUpper ? E.ToUpper() : E.ToLower()); continue; }

                // Letra I:
                if (III.Contains(letter)) { value = value.ReplaceAt(i, isUpper ? I.ToUpper() : I.ToLower()); continue; }

                // Letra O:
                if (OOO.Contains(letter)) { value = value.ReplaceAt(i, isUpper ? O.ToUpper() : O.ToLower()); continue; }

                // Letra U:
                if (UUU.Contains(letter)) { value = value.ReplaceAt(i, isUpper ? U.ToUpper() : U.ToLower()); continue; }

            }
            return value;
        }

    }
}
