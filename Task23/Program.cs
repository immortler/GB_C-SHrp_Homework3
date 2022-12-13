/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125   */

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
        Console.WriteLine("Error: enter integer number above null.");
        }
    }

    return result;
}

void PrintSquaresOfNumbs(int number)
{
    if (number == 1)
    {Console.Write($"Cubes of number 1 is 1.");}
    else
    {
        Console.Write($"Cubes of numbers from 1 to {number} is ");
        for (int i = 1; i <= number; i++)
        {
            Console.Write($"{i*i*i}");
            if (i != number)
            {Console.Write(", ");}
            else
            {Console.Write(".");}
        }
    }
}

int number = GetNumber("Enter a number:");
PrintSquaresOfNumbs(number);
