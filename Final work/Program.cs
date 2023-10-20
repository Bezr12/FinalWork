﻿Commands();
string[] array = new string[] {};

string fromUser = ReadInput("Введите номер массива: ");
switch (fromUser)
{
    case "1":
        array = new string[] { "Home", "5", "Work", "^^" };
        break;
    case "2":
        array = new string[] { "4554", "111", "-55", "gitHub" };
        break;
    case "3":
        array = new string[] { "Russia", "Krasnoufimsk", "MSK" };
        break;
    default:
        Console.WriteLine($"{fromUser} - такого массива нету");
        break;
}


int lenNewArray = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) lenNewArray++;
}

string[] newArray = new string[lenNewArray];
int idx = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[idx] = array[i];
        idx++;
    }
}

PrintArray(array);
Console.Write("→ ");
PrintArray(newArray);

// Функция: Вывод команд для работы с программой
void Commands()
{
    Console.WriteLine();
    Console.WriteLine("Список массивов:");
    Console.WriteLine("1 – использовать массив: [“Home”, “5”, “work”, “^^”]");
    Console.WriteLine("2 – использовать массив: [“4554”, “111”, “-55”, “gitHub”]");
    Console.WriteLine("3 – использовать массив: [“Russia”, “Krasnoufimsk”, “MSK”]");
    Console.WriteLine();
}

// Функция ввода
string ReadInput(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}

//  Функция вывода массива в терминал
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}