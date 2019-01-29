namespace SitekitSeleniumTest
{
    public static class StringExtensions
    {
        public static string RemoveSpacesFromString(this string stringWithSpaces)
        {
            return stringWithSpaces.Replace(" ", "");
        }

        public static string RemoveCommasFromString(this string stringWithCommas)
        {
            return stringWithCommas.Replace(",", "");
        }
    }
}
