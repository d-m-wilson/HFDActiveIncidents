using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFDActiveIncidents
{
    public static class StringExtensions
    {
        public static string Clip(this string s, int MaxLength)
        {
            if (s == null || s.Length < MaxLength)
            {
                return s;
            }
            else
            {
                return s.Substring(0, MaxLength);
            }
        }
    }
}
