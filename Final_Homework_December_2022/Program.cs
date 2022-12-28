// Программа из предложенного пользователем массива строк выбирает строки 
// длиной 3 символа и заносит их в отдельный массив

using static Common.Helper;

// Длину массива будем формировать случайным образом путем генерации случайных чисел 
// из диапазона [2;10]

Random random = new Random();

int arrayLength = random.Next(2, 11);

// Максимальную длину интересующих нас строк оформим в виде переменной, 
// чтобы программу легко было подстраивать под другие исходные данные

uint numberOfSymbols = 3;

// Каждый этап программы при выводе на экран будем оформлять шрифтами 
// разного цвета для удобства восприятия пользователем

// Блок ввода пользователем массива строк

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"\nВведите {arrayLength} строк. \n");
Console.WriteLine("Программа сформирует массив из тех из них, которые состоят из 3-х символов");
Console.WriteLine("И выведет этот массив на экран. \n");

string nextString = string.Empty;

string[] array = new string[arrayLength];

Console.ForegroundColor = ConsoleColor.Blue;

for (int i = 0; i < arrayLength; i++)
{
    if (InputString($"Введите {i + 1}-ю строку => ", out nextString))
    {
        array[i] = nextString;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Сожалеем, но Вы не справились с задачей ввода строк. ");
        Console.WriteLine("Программа завершает работу. \n");
        Console.ResetColor();
        return;
    }
}



// bool InputString(string invit, out string nextString)
// {
//     Console.Write(invit);

//     string? inputStr = Console.ReadLine();
//     bool isStrNullOrEmpty = String.IsNullOrEmpty(inputStr);
//     if (isStrNullOrEmpty)
//     {
//         nextString = String.Empty;
//     }
//     else
//     {
//         nextString = inputStr;
//     }
//     return !isStrNullOrEmpty;
// }

// void PrintArrayOfStrings(string[] arr, string separator)
// {
//     int i = 0;
//     Console.Write("[");
//     for (; i < arr.Length - 1; i++)
//     {
//         Console.Write("{0}{1}{2}", "\"", arr[i], "\"");
//         Console.Write(separator);
//     }
//     Console.WriteLine("{0}{1}{2}{3}", "\"", arr[i], "\"", "]");
// }

// int QtyOfStringsNotLongerThan (string[] arr, uint length)
// {
//     int qtyOfStrings = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i].Length <= length)
//         {
//             qtyOfStrings = qtyOfStrings + 1;
//         }
//     }
//     return qtyOfStrings;
// }

