using System.Linq;

namespace LinqIsGod
{
    public static class StringUtils
    {
        public static string linqSubstring(this string String, int start, int end)
        {
            return string.Join("", String.ToList()
                .GetRange(start, end - start));
        }

        public static long linqLength(this string String)
        {
            return String.ToCharArray().GetUpperBound(0) + 1;
        }

        public static int linqIndexOf(this string String, char c)
        {
            return String.ToList().FindIndex(o =>
                (o == c));

        }


        public static bool linqStartsWith(this string String, char c)
        {
            return String.ToCharArray().First() == c;
        }


        public static bool linqEndsWith(this string String, char c)
        {
            return String.ToCharArray().Last() == c;
        }

        public static string linqRemove(this string String, char c)
        {
            return string.Join("", String.ToCharArray()
                .Where(o => o != c)
                .Select(o => o));
        }

        public static string linqPadLeft(this string String, char c, int count)
        {
            String.ToList()
                .InsertRange(0, Enumerable.Repeat(c, count));
            return string.Join("", String);
        }

        public static string linqPadRight(this string String, char c, int count)
        {
            String.ToList()
                .AddRange(Enumerable.Repeat(c, count));
            return string.Join("", String);
        }

        public static string linqTrim(this string String)
        {
            return String.linqRemove('\0');
        }

        public static string linqTimStart(this string String)
        {
            return "";
        }

        public static string linqTrimEnd(this string String)
        {
            return "";
        }
    }
}
