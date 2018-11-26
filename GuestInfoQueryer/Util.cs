using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuestInfoQueryer
{
    static class Util
    {
        public static string EncodingString(string s, string codePageTo, string codePageFrom)
        {
            string result = "";
            result = Encoding.GetEncoding(codePageTo).GetString(Encoding.GetEncoding(codePageFrom).GetBytes(s));
            return result;
        }
    }
}
