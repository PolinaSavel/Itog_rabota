// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Какое количество элементов вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());
string[] StringsArray = new string[size];

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    StringsArray[i] = element;
}

string[] FinalArray = new string[size];
int m = 0;
int max = 3;
Console.Write("Новый массив: ");

for (int j = 0; j < size; j++)
{
    if (StringsArray[j].Length <= max)
    {
        FinalArray[m] = StringsArray[j];
        m++;
    }
}
Console.WriteLine();
PrintArray(FinalArray);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
