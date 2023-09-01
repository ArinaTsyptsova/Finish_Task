string[] ResultArray(string[] firstArray)
{
    int newSize = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3) newSize++;
    }
    string[] newArray = new string[newSize];
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            newArray[count] = firstArray[i];
            count++;
        }
    }
    return newArray;
}

string[] InputArray(int size)
{
    string[] stringArray = new string[size];
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        stringArray[i] = Console.ReadLine();
    }
    return stringArray;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetInput("Введите количество элементов: ");
string[] firstArray = InputArray(size);
string[] secondArray = ResultArray(firstArray);

Console.WriteLine($"[{String.Join(", ", (firstArray))}] -> [{String.Join(", ", (secondArray))}]");