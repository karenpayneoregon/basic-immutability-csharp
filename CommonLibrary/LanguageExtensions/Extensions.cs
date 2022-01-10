using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary.Classes;

namespace CommonLibrary.LanguageExtensions
{
    public static class Extensions
    {
        /// <summary>
        /// Convert bool to Yes or No
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string ToYesNoString(this bool source) => source ? "Yes" : "No";
        public static T GetLast<T>(this List<T> source) => source[^1];
        public static T GetLast<T>(this T[] source) => source[^1];
    }
}
