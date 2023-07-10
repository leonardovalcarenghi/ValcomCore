using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValcomCore.ExtensionMethods.Strings
{

    /// <summary>
    /// Métodos para verificar se uma string contém tipo de conteúdo específico.
    /// </summary>
    public static class HasStringMethods
    {
        /// <summary>
        /// Verifica se a string contém contéudo.
        /// </summary>
        public static bool HasContent(this string value) => !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value));

        /// <summary>
        /// Verifica se a string contém pelo menos uma letra.
        /// </summary>
        public static bool HasLetter(this string value) => value.Any(char.IsLetter);

        /// <summary>
        /// Verifica se a string contém pelo menos um número.
        /// </summary>
        public static bool HasNumber(this string value) => value.Any(char.IsDigit);

        /// <summary>
        /// Verifica se a string contém pelo menos uma letra em caixa alta.
        /// </summary>
        public static bool HasUpper(this string value) => value.Any(char.IsUpper);

        /// <summary>
        /// Verifica se a string contém pelo menus uma letra em caixa baixa.
        /// </summary>
        public static bool HasLower(this string value) => value.Any(char.IsLower);

        public static bool HasSpecialChar(this string value)
        {
            throw new NotImplementedException();
        }
    }
}
