/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int[] GetUserNumbers()
{
    Console.Write("Enter amount of numbers: ");
    int amountOfNum = int.Parse(Console.ReadLine());
    int[] numbers = new int[amountOfNum];

    for (int i = 0; i < amountOfNum; i++)
    {
        if (i < amountOfNum - 1)
            Console.Write("Enter next number: ");
        else
            Console.Write("Enter final number: ");
            
        numbers[i] = int.Parse(Console.ReadLine());
    }

    return numbers;
}

int NumbersCount(int[] numbers)
{
    int count = 0;

    foreach (int item in numbers)
    {
        if (item > 0)
            count++;
    }
    return count;
}

int[] array = GetUserNumbers();
int result = NumbersCount(array);
Console.WriteLine();
Console.WriteLine($"Amount of positive numbers -> {result}");