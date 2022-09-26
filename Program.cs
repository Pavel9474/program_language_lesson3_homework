// See https://aka.ms/new-console-template for more information
int GetNumber()
{
    Console.WriteLine("Введите число ");
    return Convert.ToInt32(Console.ReadLine());
}
void GetPow(int N)
{
    int i = 0;
    while (i <= N)
    {
    Console.Write(Math.Pow((i),3)+", ");
    i ++;
    }
}
GetPow(GetNumber());