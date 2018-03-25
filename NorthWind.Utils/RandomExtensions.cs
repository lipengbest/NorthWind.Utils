using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Utils
{
    public static class RandomExtensions
    {
        public static long NextLong(this Random random)
        {
            return (long)(random.NextDouble() * long.MaxValue);
        }
    }
}
