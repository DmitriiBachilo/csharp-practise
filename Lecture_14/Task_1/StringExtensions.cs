using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lect14.Task1
{
    static class StringExtensions
    {
        public static string Pruning(this string str)
        {
            const int length = 5;
            if (str.Length > length)
            {
                return str.Substring(0, length) + "...";
            }
            return str;
        }
    }
}
