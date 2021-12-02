using System.Text.RegularExpressions;

namespace ProjetoDanielEx.Common.Utilities
{
    public static class Util
    {
        /// <summary>
        /// Remove caracteres não numéricos
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string RemoveNaoNumericos(string text)
        {
            Regex reg = new Regex("[^0-9]");
            return reg.Replace(text, string.Empty);
        }
    }
}
