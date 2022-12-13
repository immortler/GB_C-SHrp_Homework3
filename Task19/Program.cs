/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да */

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect) 
    {
        Console.WriteLine(message);        
        if (int.TryParse(Console.ReadLine(), out result) && result < 100000 && result > 9999)
        {
        isCorrect = true;
        }        
        else
        {
        Console.WriteLine("Error: enter integer five-digit number.");
        }        
    }
    return result;
}

void IsItAPalindrome(int number)
{
    int firstDigit = number/10000;
    int secDigit = number/1000 - firstDigit*10;
    int thirdDigit = number/100 - firstDigit*100 - secDigit*10;
    int fourDigit = number/10 - firstDigit*1000- secDigit*100 - thirdDigit*10;
    int fifDigit = number%10;

    string yesOrNot = "error";

    if (firstDigit == fifDigit && secDigit == fourDigit)
    {
        yesOrNot = "";
    }
    else
    {
        yesOrNot = "not ";
    }
    Console.WriteLine($"Number {number} is {yesOrNot}a palindrome.");
}

int number = GetNumber("Enter a five-digit number:");
IsItAPalindrome(number);