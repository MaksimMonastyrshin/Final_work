// Итоговая проверочная работа.
// Задача алгоритмически не самая сложная, однако для полценного выполнения 
// проверочной работы необходимо:
// 1.	Создать репозиторий на GitHub
// 2.	Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части,
//      если вы выделяете ее в отдельный метод).
// 3.	Снабдить репозиторий оформленным текстовым описанием решения (файл README.md).
// 4.	Написать программу, решающую поставленную задачу.
// 5.	Использовать контроль версий в работе над этим небольшим проектом 
//      (не должно быть так что все залито одним коммитом, как минимум этапом 2,3 и 4
//      должны быть расположены в разных коммитах).
// Задача: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

// Задание начального массива строк.
Console.Clear();
string[] array = new string[] { "London", "Paris", "Milan", "Io", "Orion", "Rio", "Roma", "Tao", "Mo", "Kim", "Pak", "Tokyio" };

string[] resultArray = new string[array.Length];
string checkString = string.Empty;
int count = 0;

// Цикл перебора начального массива с отбором в результирующий массив только тех строк,
// длина которых удовлетворяет заданным требованиям.
for (int i = 0; i < array.Length; i++)
{
    checkString = array[i];
    if (StringLengthCount(checkString) < 4)
    {
        resultArray[count] = checkString;
        count++;
    }
}

PrintArray(array, ", ");
Console.Write(" -> ");
PrintArray(resultArray, ", ");

// Метод оценки длины переданных в параметрах строк.
int StringLengthCount(string paramString)
{
     return paramString.Length;
}

// Метод вывода массива на экран без пустых значений.
void PrintArray(string[] paramArray, string delimiter)
{
    Console.Write("[");
    count = paramArray.Length;
    for (int i = 0; i < count; i++)
    {
        if (String.IsNullOrEmpty(paramArray[i]) == false)
        {
            Console.Write($"\"{paramArray[i]}\"");
            Console.Write(delimiter);
        }
    }
    Console.Write("\b\b]");
}
