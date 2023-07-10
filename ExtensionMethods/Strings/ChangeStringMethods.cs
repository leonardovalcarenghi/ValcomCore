using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValcomCore.ExtensionMethods.Strings
{
    public static class ChangeStringMethods
    {



        /// <summary>
        /// 
        /// </summary>
        public static string CapitalizeWords(this string value) => CapitalizeWords(value, "");


        /// <summary>
        /// 
        /// </summary>
        public static string CapitalizeWords(this string value, params string[] ignore)
        {
            if (!value.HasContent()) { return ""; }
            value = value.ToLower();

            // Palavras:
            string[] words = value.Split(' ');
            int totalWords = words.Length;
            value = string.Empty;

            for (int i = 0; i < totalWords; i++)
            {
                string word = words[i];
                if (string.IsNullOrEmpty(word)) { continue; }

                // Verificar se valor é uma palavra ignorável:
                bool isIgnore = ignore.Contains(word);
                if (isIgnore) { value = string.Concat(value, word, " "); continue; }

                // Primeira Letra Maiúscula:
                string letter = word[0].ToString().ToUpper();
                word = string.Concat(letter, word.Substring(1));
                value = string.Concat(value, word, " ");
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
