//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// метод упорядочить по строкам двумерный массив. вход и выход - array
int[,] ArrangeTheRow(int[,] array)
{
    var tmp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (array[i, j] < array[i, j + 1])
            {
                tmp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = tmp;
            }
        }
    }
    return array;
}
// end of method
// method print array
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) System.Console.Write($"  {array[i, j]}");
        System.Console.WriteLine();
    }
}
///// end of method print array

int[,] myArray = new int[5, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 0 } };

System.Console.WriteLine("исходный массив:");
PrintArray(myArray);
int[,] sortArray = ArrangeTheRow(myArray);
System.Console.WriteLine("Задача 54 отсортированный массив:");
PrintArray(sortArray);

// end of Задача 54

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// массив  int [,] sortArray[5,2] уже получен
// метод вход - двумерный массив, выход - номер строки с наименьшей суммой элементов
int GetRowMinAmount(int[,] array)
{
    int[] amount = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) amount[i] = amount[i] + array[i, j];
    }
    int rowMinAmount = 0;
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        if (amount[i + 1] < rowMinAmount) rowMinAmount = i + 1;
    }
    return rowMinAmount;
}
// end of method

System.Console.WriteLine($" Задача 56  строка с наименьшей суммой элементов - {GetRowMinAmount(sortArray)} ");

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// уже заданы и заполнены два масиива int myArray[5,2] и int sortArray[5,2]
// будем считать, что вторая матрица - не 5 на 2, а 2 на 5
// без методов

int[,] newArray = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        newArray[i, j] = 0;
        for (int m = 0; m < 2; m++)
        {
            newArray[i, j] = newArray[i, j] + (myArray[i, m] * sortArray[j, m]); // должно быть наоборот, но у нас второй массив "перевернут" 
        }
    }
}
System.Console.WriteLine(" Задача 58 произведение двух матриц");
PrintArray(newArray);


