﻿/*
Задача 25: Напишите цикл,
 который принимает на вход два числа (A и B) 
 и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/


int Dbl(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    
    return result;
}

  Console.Write("Введите число : ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("В какую степень: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int dbl = Dbl(numberA, numberB);
  Console.WriteLine($"{dbl}");
