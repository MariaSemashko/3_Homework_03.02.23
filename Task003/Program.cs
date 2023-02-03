/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не натуральное число. Повторите ввод");
        }
    }

    return result;
}

void GetCube(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{i*i*i}, ");
    }
}

int number = GetNumber("Введите натуральное число");
GetCube(number);