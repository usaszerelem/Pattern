using NUnit.Framework;
using System;
using Helper;

namespace UTestPattern
{
    public class WildcardPatternMatchSingleChar
    {
        [Test()]
        public static void PureCaseInsensitive()
        {
            Assert.IsTrue(Pattern.IsWildcardMatch("Abc.txt", "a?c.?x?", false));
            Assert.IsTrue(Pattern.IsWildcardMatch("Abc.txt", "???.???", false));
            Assert.IsTrue(Pattern.IsWildcardMatch("Abc.txt", "A??.t?T", false));
        }

        [Test()]
        public static void PureCaseSensitive()
        {
            Assert.IsFalse(Pattern.IsWildcardMatch("Abc.txt", "a?c.?x?", true));
            Assert.IsTrue(Pattern.IsWildcardMatch("Abc.txt", "???.???", true));
            Assert.IsFalse(Pattern.IsWildcardMatch("Abc.txt", "A??.t?T", true));
        }
    }
}
