// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 

int[] arr = new int [8];
Console.WriteLine("введите восемь значений: ");

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Массив: ");
Console.Write(string.Join("/", arr)); 