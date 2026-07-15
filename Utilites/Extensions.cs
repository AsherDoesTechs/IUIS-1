namespace IUIS.Utilities
{
    public static class Extensions
    {
        public static bool IsNullOrEmpty(this string value) => string.IsNullOrWhiteSpace(value);
    }
}