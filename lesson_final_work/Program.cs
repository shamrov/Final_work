
string[] ParseArray(string[] array, int elements)
{
    string[] result = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= elements)
        {
            result[count] += array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}

void PrintArray(string[] array)
{
    System.Console.WriteLine($"[{String.Join(", ",array)}]");
}

string[] array = { "hello", "2", "world", ":-)" };
string[] arrayParse = ParseArray(array, 3);
PrintArray(array);
System.Console.WriteLine();
PrintArray(arrayParse);


// Вариант с простым выводом

// void ParseArray(string[] array, int elements)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i].Length <= elements)
//         {
//             System.Console.WriteLine(array[i]);
//         }
//     }
// }


// ParseArray(array, 3);