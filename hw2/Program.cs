/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = 1;
double resultUser = 0;
while (resultUser < Math.Pow(userNumber, 3))
{
    resultUser = Math.Pow(result, 3);
    Console.Write($"{resultUser} ");
    result++;
}


















/*
int AnyNumber(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result) || result <= 1)
    {
        Console.Write($"Ошибка ввода! Ожидается целое число больше единицы. {userInformation} ");
    }
    return result;
}

int number = AnyNumber("Введите целое число N > 1: ");

int[] NumberVKube (int number)
{
    int[] result = new int [number];
    for(int i = 1; i <= number; i++)
    {
        result[i - 1] = (int)(Math.Pow(i, 3));
    }
    return result;
}

int[] table = NumberVKube(number);

foreach (var value in table)
{
    Console.Write(value + " ");
}
*/
