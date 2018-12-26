using System;
using System.Text;

namespace Helper
{
    public class Pattern
    {
        static public bool IsWildcardMatch(string sFilename, string sPattern, bool bCaseSensitive)
        {
            try
            {
                bool IsMatch = true;

                if (bCaseSensitive == false)
                {
                    sFilename = sFilename.ToLower();
                    sPattern = sPattern.ToLower();
                }

                for (int nIdxFile = 0, nIdxPattern = 0;
                    nIdxFile < sFilename.Length && nIdxPattern < sPattern.Length && IsMatch == true;
                    nIdxFile++, nIdxPattern++)
                {
                    if (sPattern[nIdxPattern] == '?')
                        continue;

                    if (sPattern[nIdxPattern] == '*')
                    {
                        int newIdx = sPattern.IndexOf('.', nIdxPattern);

                        if (newIdx != -1)
                        {
                            nIdxPattern = newIdx;

                            newIdx = sFilename.IndexOf('.', nIdxFile);

                            if (newIdx != -1)
                            {
                                nIdxFile = newIdx;
                            }
                            else
                            {
                                // File "Abc", Pattern "*.txt"
                                IsMatch = false;
                            }
                        }
                        else
                        {
                            nIdxPattern = sPattern.Length;
                        }

                    }
                    else if (sFilename[nIdxFile] != sPattern[nIdxPattern])
                    {
                        IsMatch = false;
                    }
                }

                return (IsMatch);
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder("IsWildcardMatch(), ");
                sb.AppendLine(string.Format("sFilename: {0}, ", sFilename));
                sb.AppendLine(string.Format("sPattern: {0}, ", sPattern));
                sb.AppendLine(string.Format("bCaseSensitive: {0}, ", bCaseSensitive));

                throw new Exception(sb.ToString(), ex);
            }
        }
    }
}
