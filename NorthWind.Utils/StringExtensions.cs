using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Utils
{
    public static class StringExtensions
    {
        private static readonly string CarriageReturn = "\n";
        //private static readonly string LineFeed = "\r";
        private static readonly string LFCR = "\r\n";

        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static string RemoveNewLine(this string line)
        {
            if (line.EndsWith(CarriageReturn, StringComparison.Ordinal))
            {
                int removePos = line.Length - 1;
                if (line.EndsWith(LFCR, StringComparison.Ordinal))
                {
                    removePos--;
                }
                line = line.Remove(removePos);
            }
            return line;
        }
    }
}
