using System;

namespace CSPOS.Domain.Enums
{
    public static class EnumExtensions
    {
        public static string ConvertToString(this Enum eff)
        {
            return Enum.GetName(eff.GetType(), eff);
        }

        public static EnumType ConverToEnum<EnumType>(this string enumValue)
        {
            return (EnumType)Enum.Parse(typeof(EnumType), enumValue);
        }

        public static int ConvertToInt(this Enum eff)
        {
            return Convert.ToInt32(eff);
        }
    }
}
