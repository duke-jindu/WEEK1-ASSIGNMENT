//3.Given a string s and a character letter, return the percentage of characters in s that equal letter
//rounded down to the nearest whole percent.
//Input: s = "foobar", letter = "o"
//Output: 33

Console.WriteLine("");

string s = "foobar";
char letter = 'o';


int Position = 0;

foreach (char alpherbet in s)
{
    if (alpherbet == letter)
    {
        Position++;
    }
}
int PositionPercentage = Position * 100 / s.Length;
Console.WriteLine("the nearest Whole PERCENT is {0}: ", PositionPercentage);

//int strings = s.Length;
//for (int i =0; i < strings; i++)
//{
//  if(s.(i) == letter)
//  {
//      count++;
// }
// }
// return (count * 100) / (strings) ;
