#region

using System.Collections.Generic;
using NUnit.Framework;
using dff.Extensions;

#endregion

namespace RomanNumerals
{
    public class RomanNumeralsTests
    {
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
            var converter = new RomanConverter();
            var romanString = converter.Convert(arabic);

            Assert.AreEqual(roman, romanString);
        }

        [Test]
        public void ConvertNull()
        {
            var converter = new RomanConverter();
            var romanString = converter.Convert(null);

            Assert.AreEqual("Nulla", romanString);
        }
    }

    public class RomanConverter
    {
        public string Convert(string s)
        {
            if (string.IsNullOrEmpty(s)) return "Nulla";

            var insertedInt = s.TryToInt();

            var romanLiterals = new Dictionary<int, string>
                {
                    {1000, "M"},
                    {900, "CM"},
                    {500, "D"},
                    {400, "CD"},
                    {100, "C"},
                    {90, "XC"},
                    {50, "L"},
                    {40, "XL"},
                    {10, "X"},
                    {9, "IX"},
                    {5, "V"},
                    {4, "IV"},
                    {1, "I"}
                };

            var returnValue = string.Empty;
            var counter = 0;
            foreach (var romanLiteral in romanLiterals)
            {
                while (counter + romanLiteral.Key <= insertedInt)
                {
                    counter += romanLiteral.Key;
                    returnValue += romanLiteral.Value;
                }
            }
            return returnValue;
        }
    }
}