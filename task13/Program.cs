// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, 
// что третьей цифры нет.

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
if (A < 100 & A > -100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (A > 1000 || A < -1000)
    {
        int N = A / 10;
        A = N;
    }
    int B = A % 10;
    if (B < 0)
    {
        B = B * -1;
    }
    Console.WriteLine("Третья цифра --> " + B);
}
