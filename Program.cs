//Задача 2 - программа принимает на вход два числа и выдает какое число большее, а какое меньшее

Console.WriteLine("Задача 2. Давайте найдем максимум и минимум из двух чисел?");
Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine());
if(a>b)
{
    Console.Write("Максимум это: ");
    Console.WriteLine(a);
    Console.Write("Минимум это: ");
    Console.WriteLine(b);
}
else
{
    Console.Write("Максимум это: ");
    Console.WriteLine(b);
    Console.Write("Минимум это: ");
    Console.WriteLine(a);
}

//Задача 4 - программа принимает на вход три числа и выдает максимальное из этих чисел

Console.Write("Задача 4. Для определения максимума введите три числа через запятую ");
string[] num = Console.ReadLine().Split(','); //объявляем одномерный массив num[] тип содержимого - строка
    int c = int.Parse(num[0]); //переводим строки в целые числа
    int d = int.Parse(num[1]);
    int e = int.Parse(num[2]);
if(c>d&c>e)
{
    Console.Write("Максимум это: ");
    Console.WriteLine(c);
}
else if(d>c&d>e)
    {
        Console.Write("Максимум это: ");
        Console.WriteLine(d);
    }
    else 
    {
        Console.Write("Максимум это: ");
        Console.WriteLine(e);
    }

//Задача 6 - программа принимает на вход число и выдает, является ли число четным

Console.Write("Задача 6. Вы хотите узнать, четное ли ваше число? Введите его ");
int f = int.Parse(Console.ReadLine());
if(f%2 == 0)
{
    Console.WriteLine("Вау, вы ввели четное число!");
}
else Console.WriteLine("Нет, ваше число нечетное");


//Задача 8 - программа принимает число N и выводит все четные числа от 1 до N

Console.Write("Задача 8. Давайте узнаем все четные числа от 1 до N. Введите N: ");
int N = int.Parse(Console.ReadLine());

for (int i = 2; i <=N;i=i+2) Console.Write($"{i} ");