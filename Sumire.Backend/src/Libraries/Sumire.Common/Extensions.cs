using System;

namespace Sumire.Common
{
    public static class StringExtensions
    {
        public static void DropBlacklistedChars(this string self)
        {
            self.Normalize();
        }
    }

    public static class GuidExtensions
    {
        public static bool IsEmpty(this Guid self)
        {
            return self == Guid.Empty;
        }
    }
}