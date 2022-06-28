/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Write("input number: ");
int n = Convert.ToInt32(Console.ReadLine()) ;

int SumDigit(int sum) 
{
    sum = n%10 + n/100 + n%100/10;
    return sum;
}

Console.Write(SumDigit (n));
