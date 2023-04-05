//1. Given an array strs of alphanumeric strings, return the maximum value of any string in strs.
//Input: strs = ["alic3", "bob", "3", "4", "00000"]
//Output: 5
//Explanation:
//-"alic3" consists of both letters and digits, so its value is its length, i.e. 5.
//- "bob" consists only of letters, so its value is also its length, i.e. 3.
//- "3" consists only of digits, so its value is its numeric equivalent, i.e. 3.
//- "4" also consists only of digits, so its value is 4.
//- "00000" consists only of digits, so its value is 0.
//Hence, the maximum value is 5, of "alic3".

Console.WriteLine("");
string[] strings = { "alic3", "bob", "3", "4", "00000" };

maxnumber(strings);


static int maxnumber(string[] strings)
{
    var Max = 0;
    foreach (var element in strings)
    {
        Max = Math.Max(Max, element.Length);
    }
    Console.WriteLine("{0} is the Maximum Value of the String", Max);
    return Max;
}
