/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами.
**Примеры**:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

Console.Clear();
string[] symbolsArray = {"hello", "2", "world", ":-)"};
// string[] symbolsArray = {"1234", "1567", "-2", "computer science"};
// string[] symbolsArray = {"Russia", "Denmark", "Kazan"};
string[] threeSymbols = new string[FindCountThreeSymbolsElement(symbolsArray)];

int index = 0;
for (int i = 0; i < symbolsArray.Length; i++)
{
    if (symbolsArray[i].Length <= 3) 
    {
        threeSymbols[index] = symbolsArray[i];
        index++;
    }
}

PrintStringArray(symbolsArray);
Console.Write(" -> ");
PrintStringArray(threeSymbols);
Console.WriteLine();

void PrintStringArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    Console.Write($"\"{array[array.Length - 1]}\"]");
}

int FindCountThreeSymbolsElement(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}
