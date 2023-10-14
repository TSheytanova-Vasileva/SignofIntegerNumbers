
static string CompareStr(string s1, string s2)
{
    if (s1.CompareTo(s2) > 0)
    {
        return s1;
    }
    else
    {
        return s2;
    }

}

static char CompareChar(char l1, char l2)
{
    if (l1 > l2)
    {
        return l1;
    }
    else
    {
        return l2;
    }
}

static int CompareNamber(int n1, int n2)
{
    if (n1 > n2)
    {

        return n1;
    }
    else
    {
        return n2;
    }

}


string valuType = Console.ReadLine();

    if (valuType == "int")
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine(CompareNamber( n1, n2));
    }
    else if (valuType == "char")
    {
        char l1 = char.Parse(Console.ReadLine());
        char l2 = char.Parse(Console.ReadLine());
        Console.WriteLine(CompareChar(l1, l2));
    }
    else if (valuType == "string")
    {
        String s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        Console.WriteLine(CompareStr(s1, s2));
    }

