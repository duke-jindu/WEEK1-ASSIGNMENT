Console.WriteLine("Hello, World!");
//DIDNT HAVE TIME TO COMPLETE


string[] Names = { "Mary", "John", "Emma" };
int[] Height = { 180, 165, 170 };

SortHeight(Names, Height);
static string[] SortHeight(string[] Names, int[] Height)
{
    int height = Height.Length;
    int[][] data = new int[Height.Length][];

    for (int i = 0; i < Height.Length; i++)
    {
        data[i] = new int[] { Height[i], i };
    }

    Array.Sort(data, Height);
    string[] newHeight = new string[Height.Length];
    for (int i = 0; i < newHeight.Length; i++)
    {
        newHeight[i] = Names[Height[i]];
    }
    return newHeight;
    Console.WriteLine(newHeight);
}