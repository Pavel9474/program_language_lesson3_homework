// Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
// double GetNumber(string name)
// {
//     Console.WriteLine("Введите координату " + name);
//     return Convert.ToDouble(Console.ReadLine());
// }
int GetNumber()
{
   Console.WriteLine("Введите пятизначное число:");
   return Convert.ToInt32(Console.ReadLine()); 
}
void Polindrom()
{
int number = GetNumber();
int n = number;
int i = 0;
while (number > 0)
{
    int ostatok = number % 10;
    i = i*10 + ostatok;
    number = number/10;
}
if (n == i)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
}
Polindrom();