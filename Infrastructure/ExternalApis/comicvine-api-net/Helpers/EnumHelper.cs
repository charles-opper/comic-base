using System;

namespace Thoorium.Comicvine.Helpers
{
    public static class EnumHelper
    {
        public static string CleanEnumAndReturnAsLowercaseString(Enum EnumToProcess)
        {
            if (EnumToProcess == null)
                return null;

            return EnumToProcess.ToString().ToLowerInvariant().Replace(" ", string.Empty);
        }
    }
}