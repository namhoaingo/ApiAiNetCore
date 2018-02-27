using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ApiAiNetCore.Internal.Attributes
{
    /// <summary>
    /// Alternative value for enums
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    internal class AlternativeValueAttribute: Attribute
    {
        public IEnumerable<object> Values { get; set; }

        public AlternativeValueAttribute(params object[] value)
        {
            Values = value;
        }
    }

    internal static class AlternativeValue
    {

        private static AlternativeValueAttribute GetAttribute(System.Enum origin)
        {
            var originInfo = origin.GetType().GetMember(origin.ToString()).First();
            return (AlternativeValueAttribute)Attribute.GetCustomAttribute(originInfo, typeof(AlternativeValueAttribute));
        }

        public static string GetAlternativeString(this System.Enum origin)
        {
            return GetAttribute(origin).Values.FirstOrDefault()?.ToString();
        }

        public static IEnumerable<string> GetAlternativeStrings(this System.Enum origin)
        {
            return GetAttribute(origin).Values.Select(x => x.ToString());
        }
    }
}
