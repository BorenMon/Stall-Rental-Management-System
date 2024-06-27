using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Stall_Rental_Management_System.Utils;


namespace Stall_Rental_Management_System.Helpers
{
    public static class EnumHelper
    {
        public static string GetDisplayName(Enum enumValue)
        {
            var displayName = enumValue.GetType()
                .GetMember(enumValue.ToString())[0]
                .GetCustomAttribute<DisplayNameAttribute>(false)
                ?.DisplayName;

            return displayName ?? enumValue.ToString();
        }

        public static List<KeyValuePair<Enum, string>> GetEnumDisplayNames<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T))
                       .Cast<Enum>()
                       .Select(e => new KeyValuePair<Enum, string>(e, GetDisplayName(e)))
                       .ToList();
        }
        
        public static bool TryGetEnumValueFromDisplayName<T>(string displayName, out T enumValue) where T : Enum
        {
            foreach (var value in Enum.GetValues(typeof(T)).Cast<T>())
            {
                if (!GetDisplayName(value).Equals(displayName, StringComparison.OrdinalIgnoreCase)) continue;
                enumValue = value;
                return true;
            }
            enumValue = default;
            return false;
        }
        
        public static string ConvertToReadableFormat(string constantFormat)
        {
            if (string.IsNullOrEmpty(constantFormat))
                return string.Empty;

            var words = constantFormat.Split('_');
            for (var i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
            return string.Join(" ", words);
        }
    }
}
