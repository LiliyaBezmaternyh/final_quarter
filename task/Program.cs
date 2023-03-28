// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше или равна три символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма.
Console.Clear();

string[] array1 = new string[4] {"hello", "2", "world", ";-)"};
Console.WriteLine(String.Join(", ", array1));
string[] array2 = new string[array1.Length];
void SecondArray(string[] array1, string[] array2)
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
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(array1, array2);
PrintArray(array2);
