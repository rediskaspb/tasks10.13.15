// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите цифру дня недели: ");
// string a = Console.ReadLine();
int a = Convert.ToInt32(Console.ReadLine());
if(a < 1 || a > 7)
{
    Console.WriteLine("в неделе 7 дней");
}
else if(a == 6)
{
    Console.WriteLine("Да");
}
else if(a == 7)
{
    Console.WriteLine("Нет");
}
else if(a == 1 || a == 2 || a == 3 || a == 4 || a == 5 )
{
    Console.WriteLine("Нет");
}
