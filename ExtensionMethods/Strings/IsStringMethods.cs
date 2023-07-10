using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValcomCore.ExtensionMethods.Strings
{
    public static class IsStringMethods
    {

        /// <summary>
        /// Verifica se string é nula.
        /// </summary>
        public static bool IsNull(this string value) => value == null;

        /// <summary>
        /// Verifica se string contém o coteúdo exato.
        /// </summary>
        public static bool IsContent(this string value, string content) => value == content;

        /// <summary>
        /// Verifica se string é somente letras.
        /// </summary>
        public static bool IsLetter(this string value) => value.All(char.IsLetter);

        /// <summary>
        /// Verifica se string é somente números.
        /// </summary>
        public static bool IsNumber(this string value) => value.All(char.IsDigit);

        /// <summary>
        /// Verifica se string é letras em caixa alta.
        /// </summary>
        public static bool IsUpper(this string value) => value.All(char.IsUpper);

        /// <summary>
        /// Verifica se string é letras em caixa baixa.
        /// </summary>
        public static bool IsLower(this string value) => value.All(char.IsLower);

        /// <summary>
        /// Verifica se string é uma data válida para fazer o parse.
        /// </summary>
        public static bool IsDate(this string value) => DateTime.TryParse(value, out _);

        /// <summary>
        /// Verifica se string é um boleano para fazer parse.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsBool(this string value) => Boolean.TryParse(value, out _);

        /// <summary>
        /// Verifica se string contém uma quantidade de caracteres específica.
        /// </summary>
        public static bool IsLength(this string value, int length) => value?.Length == length;


    }
}
