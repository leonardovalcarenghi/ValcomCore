using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValcomCore.ExtensionMethods.Strings
{
    public static class ReplaceStringMethods
    {

        public static string ReplaceMultipleWhiteSpace(this string value)
        {
            IEnumerable<string> list = value.Split(' ').Where(s => !string.IsNullOrWhiteSpace(s));
            value = string.Join(" ", list);
            return value;
        }

        public static string ReplaceAt(this string value, int index, string newValue)
        {
            value = value.Remove(index, 1).Insert(index, newValue);
            return value;
        }

        public static string ReplaceAt(this string value, int index, int length, string newValue)
        {
            value = value.Remove(index, Math.Min(length, value.Length - index)).Insert(index, newValue);
            return value;
        }
    }
}
