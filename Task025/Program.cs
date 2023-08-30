// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



int Exponentiation(int A, int B) 
{ 
    int exp=1;
    for (int i = 0; i <B ; i++)
    {
        checked
        {
            exp*= A;
        }
    }
    return exp; 
} 

Console.WriteLine("Введите число и степень, в которую нужно его возвести: "); 
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

int exponent = Exponentiation(num1, num2); 


if(num2 < 1) 
{ 
    Console.WriteLine("Введена некорректная степень"); 
    return; 
} 
Console.WriteLine($"Результат возведения числа {num1} в степень {num2} -> {exponent}");