using NUnit.Framework;
using System;
using Helper;

namespace UTestPattern
{
    [TestFixture()]
    public class WildcardPatternsMatchAll
    {
        [Test()]
        public static void PureCaseInsensitive()
        {
            Assert.IsTrue(Pattern.IsWildcardMatch("Abc.txt", "*.txt", false));
            Assert.IsTrue(Pattern.IsWildcardMatch("Abc.txt", "*.*", false));
            Assert.IsTrue(Pattern.IsWildcardMatch("Abc.txt", "*", false));
        }

        [Test()]
        public static void PureCaseSensitive()
        {
            Assert.IsTrue(Pattern.IsWildcardMatch("Abc.txt", "*.txt", true));
            Assert.IsTrue(Pattern.IsWildcardMatch("Abc.txt", "*.*", true));
            Assert.IsTrue(Pattern.IsWildcardMatch("Abc.txt", "*", true));
        }

        [Test()]
        public static void FileCaseInsensitive()
        {
            Assert.IsTrue(Pattern.IsWildcardMatch("Abc.Txt", "*.txt", false));
            Assert.IsTrue(Pattern.IsWildcardMatch("Abc.txt", "aBc.*", false));
            Assert.IsTrue(Pattern.IsWildcardMatch("Abc.txt", "*.TXt", false));
        }

        [Test()]
        public static void FileCaseSensitive()
        {
            Assert.IsFalse(Pattern.IsWildcardMatch("Abc.Txt", "*.txt", true));
            Assert.IsFalse(Pattern.IsWildcardMatch("Abc.txt", "aBc.*", true));
            Assert.IsFalse(Pattern.IsWildcardMatch("Abc.txt", "*.TXt", true));
        }
    }
}
