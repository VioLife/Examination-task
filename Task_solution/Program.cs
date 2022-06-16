string FinishString(string[] col)
{
    string res = string.Empty;
    res = "[";
    for (int i = 0; i < col.Length - 1; i++)
    {
        res += $"{col[i]}, ";
    }
    res += $"{col[col.Length - 1]}]";
    return res;
}

string[] SolveEx(string[] mass)
{
    string[] CharArray = new string[1];
    int k = 0;
    int j = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length <= 3)
        {
            Array.Resize(ref CharArray, k = k + 1);
            CharArray[j] = mass[i];
            j++;
        }
    }
    return CharArray;
}

Console.Write("Введите значения массива, разделенные пробелом: ");
string с = Console.ReadLine()!;
char[] separators = new char[] { ' ' };
string[] arrString = с.Split(separators, StringSplitOptions.RemoveEmptyEntries);
Console.Write(FinishString(arrString) + "->" + FinishString(SolveEx(arrString)));
