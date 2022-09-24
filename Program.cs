// Напишите программу, которая выводит третью 
//цифру заданного числа или сообщает, что третьей цифры нет.
int GetNumber()
{
   Console.WriteLine("Введите число:");
   int N = Convert.ToInt32(Console.ReadLine());
   return N; 
}
void Thirdnumber(int N)
{
    if (N>99)
    {
        while (N>999)
        {
        N=N/10;
        }  
        N = N%10;
        Console.WriteLine(N);      
    }
    else
    {
    Console.WriteLine("Третьей цифры нет");
    }
}
Thirdnumber(GetNumber());