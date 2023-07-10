using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ValcomCore.ExtensionMethods.Strings
{
    public static class ConversionStringMethods
    {

        /// <summary>
        /// Converter string para o tipo DateTime.
        /// </summary>
        public static DateTime? ToDate(this string value) => DateTime.Parse(value);

        /// <summary>
        /// Converter string para o tipo Bool.
        /// </summary>
        public static bool ToBool(this string value) => bool.Parse(value);

        /// <summary>
        /// Converter string para o tipo Int.
        /// </summary>
        public static int ToInt(this string value) => int.Parse(value);

        /// <summary>
        /// Converter string para o tipo decimal.
        /// </summary>
        public static decimal ToDecimal(this string value) => decimal.Parse(value);

        /// <summary>
        /// Covnerter valor da string para uma Hash256.
        /// </summary>
        public static string ToHash256(this string value)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] hash = sha256.ComputeHash(Encoding.ASCII.GetBytes(value));
            StringBuilder stringBuilder = new StringBuilder();
            for (var i = 0; i < hash.Length; i++) { stringBuilder.Append(hash[i].ToString("X2")); }
            return stringBuilder.ToString();
        }

    }
}
