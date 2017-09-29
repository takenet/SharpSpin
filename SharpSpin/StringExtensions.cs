using SharpSpin;

namespace System
{
    public static class StringExtensions
    {
        /// <summary>
        /// Spin the string content accordingly to the spinning syntax.
        /// </summary>
        /// <example>
        /// The syntax "The {quick|fast} brown fox jumped over the lazy dog." can produce the following values:
        /// - The quick brown fox jumped over the lazy dog.
        /// - The fast brown fox jumped over the lazy dog.
        /// </example>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string Spin(this string content) => Spinner.Spin(content);
    }
}
