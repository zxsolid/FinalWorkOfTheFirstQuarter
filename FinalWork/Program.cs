// Из имеющегося массива строк сформировать массив строк, длинна которых меньше либо равна 3 символам.

Console.Clear();

string[] SmallString(string[] ar)
{
    List <string> result = new List<string>();
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i].Length<=3){
            result.Add(ar[i]);
        }
    }
    string [] massForOut=result.ToArray<string>();
    return massForOut;
}

string[] Massive1 = new string[] { "hello", "2", "world", ":-)"};
string[] Massive2 = SmallString(Massive1);

Console.WriteLine("Это изначальный массив");
Console.WriteLine(String.Join(", ", Massive1));
Console.WriteLine("Это итоговый массив");
Console.WriteLine(String.Join(", ", Massive2));