//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void PrintTruaTable(int N){
    if (N < 1){
        Console.WriteLine("Ведите число больше 0");
    }
    else{
        for (int i = 1; i <= N; i++)
        Console.Write($"{Math.Pow(i,3)}, ");
    }
}

//-------------

 Console.Write("Введите число для поиска последовательности кубов: ");
 int N = int.Parse(Console.ReadLine());
 Console.Write($"{N} -> ");
 PrintTruaTable(N);