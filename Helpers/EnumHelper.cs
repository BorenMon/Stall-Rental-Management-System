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
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayNameAttribute>()
                            ?.DisplayName ?? enumValue.ToString();
        }

        public static List<KeyValuePair<Enum, string>> GetEnumDisplayNames<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T))
                       .Cast<Enum>()
                       .Select(e => new KeyValuePair<Enum, string>(e, GetDisplayName(e)))
                       .ToList();
        }
    }
}
