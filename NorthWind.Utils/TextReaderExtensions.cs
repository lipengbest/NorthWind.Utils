using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Utils
{
    public static class TextReaderExtensions
    {
        public static string ReadLineNewLine(this TextReader reader)
        {
            StringBuilder sb = new StringBuilder();
            while (reader.Peek() != -1)
            {
                char c = (char)reader.Read();
                sb.Append(c);
                if (c == '\n')
                    break;
            }
            var line = sb.ToString();
            return line.Length > 0 ? line : null;
        }

        
    }
}
