/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
*/

void FindFreeSymbols(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
            {
            array2[count] = array1[i];
            count++;
            }
    }
}
void PrintArray(string[] array)
{
    Console.WriteLine("строки массима длинна которых <= 3 символов:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}

void Main()
{
    string[] array1;
    Console.WriteLine("Введите массив строк через пробел");
    string stroka = Console.ReadLine();
    array1 = stroka.Split(' ');
    var result = new string[array1 .Length];
    string[] array2 = new string[array1.Length];
    FindFreeSymbols(array1, array2);
    PrintArray(array2);
}

Main();