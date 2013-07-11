#region

using NUnit.Framework;

#endregion

namespace RomanNumerals
{
    public class RomanNumeralTests
    {
        [Test]
        public void ArabianToNumeral1()
        {
            var converter = new RomanNumeralConverter(null);
            Assert.AreEqual("NULLA", converter.ToString());
        }

        [TestCase("1", "I")]
        [TestCase("2", "II")]
        [TestCase("3", "III")]
        [TestCase("4", "IV")]
        [TestCase("5", "V")]
        [TestCase("6", "VI")]
        [TestCase("7", "VII")]
        [TestCase("8", "VIII")]
        [TestCase("291", "CCXCI")]
        [TestCase("49", "XLIX")]
        [TestCase("490", "CDXC")]
        [TestCase("950", "CML")]
        [TestCase("999", "CMXCIX")]
        public void ConvertToRoman(string arabic, string roman)
        {
            var converter = new RomanNumeralConverter(arabic);
            Assert.AreEqual(roman, converter.ToString());
        }
    }
}