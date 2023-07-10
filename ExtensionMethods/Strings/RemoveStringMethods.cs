using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValcomCore.ExtensionMethods.Strings
{
    public static class RemoveStringMethods
    {

        /// <summary>
        /// Remover espaços em branco de uma string.
        /// </summary>
        public static string RemoveWhiteSpace(this string value) => value.Trim().Replace(" ", "");

        /// <summary>
        /// Remover números de uma string.
        /// </summary>
        public static string RemoveNumbers(this string value) => Regex.Replace(value, @"[0-9\-]", string.Empty);

        /// <summary>
        /// Remover letras de uma string.
        /// </summary>
        public static string RemoveLetters(this string value) => Regex.Replace(value, @"[a-z/A-Z]", string.Empty);

        /// <summary>
        /// Remover apenas letras que estão em caixa alta na string.
        /// </summary>
        public static string RemoveUpperLetters(this string value) => Regex.Replace(value, @"[A-Z]", string.Empty);

        /// <summary>
        /// Remover apenas letras que estão em caixa baixa na string.
        /// </summary>
        public static string RemoveLowerLetters(this string value) => Regex.Replace(value, @"[a-z]", string.Empty);

    }
}
