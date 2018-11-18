using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelvifyMatchPattern_Console
{
    /// <summary>
    /// Extemsion Methods to be used Pattern Matching
    /// </summary>
    public static class ExtensionMethods
    {
        public static string ToStringExtension(this object obj)
        {
            return obj == null ? string.Empty : obj.ToString();
        }
        public static string Between(this string value, string a, string b)
        {
            int posA = value.IndexOf(a);
            int posB = value.LastIndexOf(b);
            if (posA == -1)
            {
                return "";
            }
            if (posB == -1)
            {
                return "";
            }
            int adjustedPosA = posA + a.Length;
            if (adjustedPosA >= posB)
            {
                return "";
            }
            return value.Substring(adjustedPosA, (posB - adjustedPosA)+1);
        }
        public static string Before(this string value, string a)
        {
            int posA = value.IndexOf(a);
            if (posA == -1)
            {
                return "";
            }
            return value.Substring(0, posA);
        }
        public static string After(this string value, string a)
        {
            int posA = value.LastIndexOf(a);
            if (posA == -1)
            {
                return "";
            }
            int adjustedPosA = posA + a.Length;
            if (adjustedPosA >= value.Length)
            {
                return "";
            }
            return value.Substring(adjustedPosA);
        }
        public static string ToErrorMessage(this Exception ex)
        {
            string errorMsg = string.Concat(Environment.NewLine, ex.Message, Environment.NewLine, ex.StackTrace);
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
                errorMsg += string.Concat(Environment.NewLine, ex.Message, Environment.NewLine, ex.StackTrace);
            }

            return errorMsg;
        }
    }
}
