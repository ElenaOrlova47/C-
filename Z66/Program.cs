//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());

int Sum = 0;

PrintNumbers(number1, number2);

void PrintNumbers(int start, int end)
{
    //System.Console.Write(start);
    Sum += start;
    
    if(start == end)
    {
        System.Console.Write(Sum);
        return;
    }
    else
    {
        PrintNumbers(start+1, end);
    }
}