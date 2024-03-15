// Задача 4**(не обязательно): Дано натуральное 
// число в диапазоне от 1 до 100 000. Создайте массив, 
// состоящий из цифр этого числа. Старший разряд 
// числа должен располагаться на 0-м индексе 
// массива, младший – на последнем. Размер массива 
// должен быть равен количеству цифр.


using System.Globalization;

Console.Write("Enter number (1 - 100000): ");
string strNumber = Console.ReadLine()!;
int index = strNumber.Length;
int initNumber = Convert.ToInt32(strNumber);
int[] numArray = new int[index];

if (index > 0 && index < 7)
{
    for (int rang = index; rang > 0; rang--)  // Убывающий цикл для поиска числа от старшего разряда к младнему 
    {
        int number = initNumber;              // Переменая для поиска числа в разряде
        for (int i = 1; i <= rang; i++)
        {
            int digit = number % 10;          // запись в digit крайнего левого числа
            if (i == rang)                    // Если верно, достигли старшего разряда
            {
                numArray[index - rang] = digit;         // Пишем в массив полученное число
            }
            number /= 10;                                // Отбрасываем последний разряд
        }
    }

    Console.Write("Numbers in array: [ ");
    foreach (int item in numArray)
    {
        Console.Write($"{item} ");
    }
    Console.Write("]");
}
else
{
    Console.Write("Number not in range (1 - 100000)");
}