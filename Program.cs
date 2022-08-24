// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
int[] CreateArray() 
{ 
    Console.WriteLine("Введите количество элементов массива"); 
    int size = Convert.ToInt32(Console.ReadLine()); 
    int[] array = new int[size]; 
    for (int i = 0; i < size; i++) 
    {    
        Console.WriteLine($"Введите {i+1} элемент массива"); 
        array[i] = Convert.ToInt32(Console.ReadLine()); 
    } 
    return array; 
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
    Console.WriteLine();
}

int YaZakipel(int[] array){
    int count = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] > 0)
    {
      count++;
    }
  }
  return count;
}

Console.Clear();
int[] myArray = CreateArray(); 
ShowArray(myArray);

int yazakipel = YaZakipel(myArray);
Console.WriteLine($"Количество положительных чисел в массиве: {yazakipel}");




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
