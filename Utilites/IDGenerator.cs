using System;

namespace IUIS.Utilities
{
    public static class IDGenerator
    {
        public static string Generate(string prefix)
        {
            return $"{prefix}-{DateTime.Now:yyyyMMdd}-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        }

        public static string GenerateSequential(string prefix, System.Collections.Generic.IEnumerable<string> existingIds)
        {
            int next = System.Linq.Enumerable.Max(System.Linq.Enumerable.DefaultIfEmpty(
                System.Linq.Enumerable.Select(existingIds, id =>
                {
                    var value = id == null ? null : System.Linq.Enumerable.LastOrDefault(id.Split('-'));
                    return int.TryParse(value, out int number) ? number : 0;
                }), 0)) + 1;
            return $"{prefix}-{DateTime.Today:yyyy}-{next:0000}";
        }
    }
}
