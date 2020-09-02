using System.Collections;
using System.Linq;

namespace LinqIsGod
{
    public static class StringUtils
    {

        /// <summary>
        ///  Returns a Substring of the specified string
        /// </summary>
        /// <param name="string">The Source String</param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static string LinqSubstring(this string @string, int start, int end)
        {
            return string.Join("", @string.ToList()
                .GetRange(start, end - start));
        }

        /// <summary>
        /// Returns the length of the specified string
        /// </summary>
        /// <param name="string">The Source String</param>
        /// <returns>the length of the string</returns>
        public static int LinqLength(this string @string)
        {
            return @string.Select(o => o).Count();
        }

        /// <summary>
        /// Returns the index of the first instance of the specified character in the string
        /// </summary>
        /// <param name="string">The Source String</param>
        /// <param name="character">The character to check for</param>
        /// <returns>the first index of the character</returns>
        public static int LinqIndexOf(this string @string, char character)
        {
            return @string.ToList().FindIndex(o =>
                (o == character));

        }

        /// <summary>
        ///  Returns whether the string starts with a specified character
        /// </summary>
        /// <param name="string">The Source String</param>
        /// <param name="character">The character to check for</param>
        /// <returns><see cref="bool"/> value</returns>
        public static bool LinqStartsWith(this string @string, char character)
        {
            return @string.ToCharArray().First() == character;
        }

        /// <summary>
        ///  Returns whether the string ends with a specified character
        /// </summary>
        /// <param name="string">The Source String</param>
        /// <param name="character">The character to check for</param>
        /// <returns></returns>
        public static bool LinqEndsWith(this string @string, char character)
        {
            return @string.ToCharArray().Last() == character;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="string">The Source String</param>
        /// <param name="character">The character to check for</param>
        /// <returns></returns>
        public static string LinqRemove(this string @string, char character)
        {
            return string.Join("", @string.ToCharArray()
                .Where(o => o != character)
                .Select(o => o));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="string">The Source String</param>
        /// <param name="character">The character to replace</param>
        /// <param name="replacementCharacter">The character to replace with</param>
        /// <returns></returns>
        public static string LinqReplace(this string @string, char character, char replacementCharacter)
        {
            return string.Join("", @string.ToCharArray()
                .Where(o => o == character)
                .Select(o => replacementCharacter)
                .ToArray());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="string">The Source String</param>
        /// <param name="length"></param>
        /// <param name="paddingChar"></param>
        /// <returns></returns>
        public static string LinqPadLeft(this string @string, int length, char paddingChar)
        {
            @string.ToList()
                .InsertRange(0, Enumerable.Repeat(paddingChar, @string.LinqLength() - length));
            return string.Join("", @string);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="string">The Source String</param>
        /// <param name="length"></param>
        /// <param name="paddingChar"></param>
        /// <returns></returns>
        public static string LinqPadRight(this string @string, int length, char paddingChar)
        {
            @string.ToList()
                .InsertRange(@string.LinqLength(), Enumerable.Repeat(paddingChar, @string.LinqLength() - length));
            return string.Join("", @string);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="string">The Source String</param>
        /// <returns></returns>
        public static string LinqTrim(this string @string)
        {
            return @string.LinqRemove('\0');
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="string">The Source String</param>
        /// <returns></returns>
        public static string LinqTimStart(this string @string)
        {
            return "";
        }

        /// <summary>
        /// Trims the end of the string of empty spaces
        /// </summary>
        /// <param name="string">The Source String</param>
        /// <returns></returns>
        public static string LinqTrimEnd(this string @string)
        {
            return "";
        }

        public static string[] LinqSplit(this string @string,char splitChar)
        {
            return "";//@string.LinqIndexOf(splitChar)
        }

        public static string LinqReverse(this string @string)
        {
            return string.Join(',',@string.ToCharArray().Reverse().Select(o=>o).ToArray());
        }

        public static string LinqJoin(this string @string,char joinchar,IEnumerable<char> source)
        {
            return "";
        }
    }
}
