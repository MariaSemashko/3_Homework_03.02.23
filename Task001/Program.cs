/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && Math.Abs(result) <= 99999 && Math.Abs(result) >= 10000)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не пятизначное число. Повторите ввод");
        }
    }

    return result;
}

string CheckPalindrome(int number)
{
    if (number % 10 == number / 10000 % 10 && number / 10 % 10 == number / 1000 % 10)
    return ($"Число {number} является палиндромом");
    else 
    return ($"Число {number} не является палиндромом");
}

int number = GetNumber("Введите пятизначное число");
string palindrome = CheckPalindrome(number);
Console.WriteLine(palindrome);
