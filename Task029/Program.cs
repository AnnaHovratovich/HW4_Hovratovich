// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


void FillArr(int[] mass, int min, int max) 
{ 
    int i = 0; 
    var random = new Random(); 
    while(i < mass.Length) 
    { 
        mass[i] = random.Next(min, max+1); 
        i++; 
    } 
} 

void PrintArr(int[] mass) 
{ 
    int i = 0;
    Console.Write("[");
    while(i < mass.Length) 
    { 
        if (i < mass.Length - 1) 
        {
            Console.Write($"{mass[i]}, "); 
        }
        else Console.Write($"{mass[i]}"); 
        i++;
    }
    Console.Write("]"); 
}



int[] array = new int[8]; 
Console.WriteLine("Введите диапазон значений элементов массива");
int minimum=Convert.ToInt32(Console.ReadLine()); 
int maximum=Convert.ToInt32(Console.ReadLine());
FillArr(array, minimum, maximum); 
PrintArr(array);