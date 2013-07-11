RomanNumerals Kata
==================

The Kata says you should write a function to convert from normal numbers to Roman Numerals: eg

1 --> I

10 --> X

7 --> VII

Values:

I	1

V	5

X	10

L	50

C	100

D	500

M	1,000

The Romans were a clever bunch. They conquered most of Europe and ruled it for hundreds of years. 
They invented concrete and straight roads and even bikinis[1]. 
One thing they never discovered though was the number zero. 
This made writing and dating extensive histories of their exploits slightly more challenging, 
but the system of numbers they came up with is still in use today. 
For example the BBC uses Roman numerals to date their programmes.


For a full description of how it works, take a look at http://www.novaroma.org/via_romana/numbers.html: 

There is no need to be able to convert numbers larger than about 3000. 
(The Romans themselves didn't tend to go any higher)

Tests
----------

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

Array
------

(1000, "M");
(900, "CM");
(500, "D");
(400, "CD");
(100, "C");
(90, "XC");
(50, "L");
(40, "XL");
(10, "X");
(9, "IX");
(5, "V");
(4, "IV");
(1, "I");