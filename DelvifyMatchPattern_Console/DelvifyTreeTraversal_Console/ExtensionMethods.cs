using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelvifyTreeTraversal_Console
{
    public static class ExtensionMethods
    {
        public static string ToStringExtension(this object obj)
        {
            return obj == null ? string.Empty : obj.ToString();
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
        public static int ToIntExtension(this object obj)
        {
            return obj == null || obj == DBNull.Value ? 0 : Convert.ToInt32(obj);
        }
        public static long ToLongExtension(this object obj)
        {
            return obj == null || obj == DBNull.Value ? 0 : Convert.ToInt64(obj);
        }
    }
}
