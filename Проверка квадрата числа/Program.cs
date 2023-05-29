/*Проверка квадрата числа

Console.WriteLine("Введите число,квадрат которого находится:");
int input1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите проверяемый результат:");
int input2 = int.Parse(Console.ReadLine());

if(input2 == input1 * input1)
{
    Console.WriteLine("True");
}
else 
{
    Console.WriteLine("False");
}

*/

Console.WriteLine("Введите число от 1 до 7");
int input = int.Parse(Console.ReadLine());

if (input<1|input>7)
{
    Console.WriteLine("Такого по счету дня недели не существует");
}

if(input == 1)
{
    Console.WriteLine("Понедельник");
}

if(input == 2)

{
    Console.WriteLine("Вторник");
}

if(input == 3)

{
    Console.WriteLine("Среда");
}

if(input == 4)

{
    Console.WriteLine("Четверг");
}

if(input == 5)

{
    Console.WriteLine("Пятница");
}

if(input == 6)

{
    Console.WriteLine("Суббота");
}

if(input == 7)

{
    Console.WriteLine("Воскресенье");
}