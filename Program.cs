// Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. 
string[] GetStringArrayFromConsole()
{
    Console.Write("Введите количество строк, которые хотите ввести: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] strArr = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите элемент массива №{0}: ", i + 1);
        strArr[i] = Console.ReadLine();
    }
    return strArr;
}
string[] GetStringArrayShorterByN(string[] arr, int N)
{
    int countElementsShorterByN = 0; //добавил счетчик сюда, не знаю что на меня нашло
    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length <= N)
            countElementsShorterByN++;
    string[] array2 = new string[countElementsShorterByN];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= N)
        {
            array2[index] = arr[i];
            index++;
        }
    }
    return array2;
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        Console.Write(arr[i] + ", "); //добавил запятую чтобы было видно количество элементов
    Console.WriteLine();
}
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
string[] arr1 = GetStringArrayFromConsole();
PrintArray(arr1);
int N = GetNumberFromConsole("Введите максимальное количество символов массива 2");
GetStringArrayShorterByN(arr1, N);
PrintArray(GetStringArrayShorterByN(arr1, N));