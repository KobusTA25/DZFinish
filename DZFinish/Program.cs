﻿
        Console.Write("Введите длинну массива: ");
        int n = Convert.ToInt32(Console.ReadLine());

        string[] array = new string[n];

        Console.WriteLine($"Введите элементы массива:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Элемент " + (i + 1) + ": ");
            array[i] = Console.ReadLine();
        }
string[] newArray = new string[array.Length];
        int count = 0;

  
        