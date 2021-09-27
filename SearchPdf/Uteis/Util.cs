using System;

namespace SearchPdf.Uteis
{
    public class Util
    {
        public static bool Contains(string source, string cont, StringComparison compare)
        {
            return source.IndexOf(cont, compare) >= 0;
        }
    }
}
