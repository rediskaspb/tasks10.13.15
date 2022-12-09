// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число: ");
// string a = Console.ReadLine();
int N = Convert.ToInt32(Console.ReadLine());
int count = N.ToString().Length;
int result = N % 10;
// Console.WriteLine(count);
if(count<3)
{
    result = (N / 10);
    Console.WriteLine("Третьей цифры нет");
    //с задачей не справилась - не пойму как зациклить, а времени подумать совсем нет(((
}
// else if(count>3)
// {
//     do 
//     {
//         int N3 = N / 10;
//     }
//     while(count>3);
// }
// else if(count==3)
// {
//     Console.WriteLine(N3);
// }
