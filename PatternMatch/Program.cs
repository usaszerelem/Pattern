using System;
using Helper;

namespace PatternMatch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Pattern.IsWildcardMatch("Abc.txt", "*.txt", false);
            Console.WriteLine("Hello World!");
        }
    }
}
