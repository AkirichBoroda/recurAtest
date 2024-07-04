//первая задача

// Console.WriteLine("первая задача"); 
// Console.WriteLine("Введите M и N (M должна быть меньше N)");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());

// if (m < n)
// {
//     recurFunc(m,n);
//     Console.WriteLine();
// }
// else
// {
//     Console.WriteLine("Введите правильные числа");
// }
// void recurFunc(int m, int n)
// {
//     Console.Write(m + " ");
//     m++;

//     if (m <= n)
//     {
//         recurFunc(m,n);
//     }
//     else
//     {
//         return;
//     }
    
// }

// ---------------------------------------------------------------------------
// вторая задача

// Console.WriteLine("Вторая задача"); 
// Console.WriteLine("Введите M и N (M и N не должны быть отрицательные)");

// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());

// int result = AckerFunc(m, n); 
// Console.WriteLine($"Значение функции Аккермана для ({m}, {n}) равно: {result}");

//  int AckerFunc(int m, int n) 
// { 
//     if (m == 0) 
//         return n + 1; 
//     else if (n == 0) 
//         return AckerFunc(m - 1, 1); 
//     else 
//         return AckerFunc(m - 1, AckerFunc(m, n - 1)); 
// } 

// -------------------------------------------------------------------------------
//третья задача

Console.WriteLine("третья задача"); 
int[] Array = { 5, 84, 1, 77, 95 }; 
 
recureReverse(Array, 0); 

void recureReverse(int[] arr, int index) 
{ 
    if (index < arr.Length) 
    { 
        
        recureReverse(arr, index + 1);
        Console.Write(arr[index] + " ");  
    } 
} 