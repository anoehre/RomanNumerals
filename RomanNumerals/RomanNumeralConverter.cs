#region

using System.Collections.Generic;
using dff.Extensions;

#endregion

namespace RomanNumerals
{
    public class RomanNumeralConverter
    {
        private readonly Dictionary<int, string> _romanNumerals = new Dictionary<int, string>();
        private readonly string _romanString;

        public RomanNumeralConverter(string arabic)
        {
            _romanNumerals.Add(1000, "M");
            _romanNumerals.Add(900, "CM");
            _romanNumerals.Add(500, "D");
            _romanNumerals.Add(400, "CD");
            _romanNumerals.Add(100, "C");
            _romanNumerals.Add(90, "XC");
            _romanNumerals.Add(50, "L");
            _romanNumerals.Add(40, "XL");
            _romanNumerals.Add(10, "X");
            _romanNumerals.Add(9, "IX");
            _romanNumerals.Add(5, "V");
            _romanNumerals.Add(4, "IV");
            _romanNumerals.Add(1, "I");

            var x = 0;
            var arabicAsInt = arabic.TryToInt();
            foreach (var romanNumeral in _romanNumerals)
            {
                while (x + romanNumeral.Key <= arabicAsInt)
                {
                    x += romanNumeral.Key;
                    _romanString += romanNumeral.Value;
                }
            }
        }

        public override string ToString()
        {
            return !string.IsNullOrEmpty(_romanString) ? _romanString : "NULLA";
        }
    }
}