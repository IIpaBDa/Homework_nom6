//Семинар 6.
//Домашнее задание.
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//Выполнил: Кельт Дмитрий Владимирович (kelt_1981@mail.ru)
//Решение:

int ReadInt(string argument) // Проверяем числовое ли значение ввел пользователь
{
    Console.Write(argument);
    int i;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Вы ввели не число!");
        Console.Write(argument);
    }
    return i;
}
int[] MakeArray(int M) // Пользователь вводит с клавиатуры M чисел
{
    int[] array = new int [M];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadInt("Введите число: "); 
    }
    return array;
}
int NotZerro(int[]array) // Посчитайте, сколько чисел больше "0" ввёл пользователь
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int M = ReadInt("Количество чисел для предстоящего ввода: ");
System.Console.WriteLine($"{NotZerro(MakeArray(M))} чисел больше нуля");
