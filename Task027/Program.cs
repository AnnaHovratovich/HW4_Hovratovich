// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumbers(int num) 
{ 
    int sum = 0;
    if(num == 0) return 0;
    while(num > 0)
    { 
        sum += num%10;
        num = num/10;
    } 
    return sum; 
} 

Console.Write("Введите число: "); 
int number = Convert.ToInt32(Console.ReadLine()); 
if (number<0) Console.Write("Некорректный ввод числа");
else Console.Write($"Сумма цифр в числе {number} равна {SumNumbers(number)}.");