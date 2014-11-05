using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClipboardRing
{
    class StringUtils
    {
        public static string GetShortMsg(string txt, int maxLen)
        {
            string retVal = "";
            if (string.IsNullOrEmpty(txt))
            {
                retVal = "...";
            }
            else
            {
                if (txt.Length <= maxLen)
                {
                    retVal = txt;
                }
                else
                {
                    retVal = txt.Substring(0, maxLen) + "...";
                }
            }
            return retVal;
        }
    }
}
