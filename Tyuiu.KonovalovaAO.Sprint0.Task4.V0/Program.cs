﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KonovalovaAO.Sprint0.Task4.V0.Lib;

namespace Tyuiu.KonovalovaAO.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            // пример линейной структуры
            // метод сложения 
            Console.WriteLine(DataService.Addition(1, 5));
            // метод вычетания 
            Console.WriteLine(DataService.Subtraction(15, 5));
            // метод умножения
            Console.WriteLine(DataService.Multiplication(10, 2));
            // метод деления
            Console.WriteLine(DataService.Division(5, 5));

            Console.ReadKey();
        }
    }
}
