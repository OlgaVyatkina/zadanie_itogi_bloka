// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры: 
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"] 
// ['1234", "1567", "-2", "computer science"] -> ["-2"] 
// ["Russia", "Denmark", "Kazan"] -> []


string[] Array1 = { "hello", "2", "world", ":-)" };
string[] Array2 = {"1234", "1567", "-2", "computer science"};
string[] Array3 = {"Russia", "Denmark", "Kazan"};

PrintArray(GetArray(Array1));
PrintArray(GetArray(Array2));
PrintArray(GetArray(Array3));


string[] GetArray(string[] array){ 
string temp = String.Empty;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        temp = temp + array[i] + " ";
}
return temp.Split()[..^1];
}


void PrintArray(string[] array)
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}
