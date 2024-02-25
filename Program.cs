Console.Write("Задайте размер массива:");
int sizeArray = Convert.ToInt32(Console.ReadLine());
//Объявление массива и занесение элементов через консоль
string[] array = new string[sizeArray];

Console.WriteLine($"Введите {sizeArray} значеня(-ий) в массив");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите строку ({i + 1}/{sizeArray})");
    array[i] = Console.ReadLine();
}

// Вычисление размера под новый массив
int sizeNewArray = 0;
for (int i = 0; i < array.Length; i++)
{
    int length = array[i].Length;
    if (length <= 3)
    {
        sizeNewArray++;
        //Проверка длины элемента массива и значние переменной sizeNewArray
        // Console.WriteLine($"Длинна элемента {array[i]} = {length}. Значение sizeNewArray = {sizeNewArray}");
    }
}

// Объявление нового массива
string[] newArray = new string[sizeNewArray];
int tempIndex = 0;

// Добавление в новый массив N элементов, согласно условию
while (tempIndex < newArray.Length)
{
    for (int i = 0; i < array.Length; i++)
    {
        int length = array[i].Length;
        if (length <= 3)
        {
            newArray[tempIndex] = array[i];
            tempIndex++;
        }
    }
}
// Вывод в консоль
Console.Clear();
Console.WriteLine($"[{string.Join(", ", array)}] → [{string.Join(", ", newArray)}]");