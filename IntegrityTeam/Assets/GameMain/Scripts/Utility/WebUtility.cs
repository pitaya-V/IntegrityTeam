using System;

namespace StarForce
{
    public static class WebUtility
    {
        public static string EscapeString(string stringToEscape)
        {
            return Uri.EscapeDataString(stringToEscape);
			//再次再次测试
        }

        public static string UnescapeString(string stringToUnescape)
        {
            return Uri.UnescapeDataString(stringToUnescape);
        }
    }
}
