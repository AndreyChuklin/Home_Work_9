using System;

namespace Task_Home
{
    class Program
    {
        static void Main(string[] args)
        {





            // Задача 64: Задайте значения M и N. 
            // Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.


            void Task64(int m, int n)
            {
                while (m <= n)
                {
                    if (m % 3 == 0) return;
                    m++;
                    Console.WriteLine(m);
                }
                Task64(m, n);
            }




            void Task66()
            {
                //Задача 66: Задайте значения M и N. 
                // Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

                int num1 = InputNumbers("Введите первое число: ");
                int num2 = InputNumbers("Введите второе число: ");
                int temp = num1;

                if (num1 > num2)
                {
                    num1 = num2;
                    num2 = temp;
                }

                PrintSumm(num1, num2, temp = 0);

                void PrintSumm(int num1, int num2, int summ)
                {
                    summ = summ + num2;
                    if (num2 <= num1)
                    {
                        Console.Write($"Сумма элементов= {summ} ");
                        return;
                    }
                    PrintSumm(num1, num2 - 1, summ);
                }

                int InputNumbers(string input)
                {
                    Console.Write(input);
                    int output = Convert.ToInt32(Console.ReadLine());
                    return output;
                }
            }

            void Task68()
            {
                //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
                // Даны два неотрицательных числа m и n.

                int m = InputNumbers("Введите m: ");
                int n = InputNumbers("Введите n: ");

                int functionAkkerman = Ack(m, n);

                Console.Write($"Функция Аккермана = {functionAkkerman} ");

                int Ack(int m, int n)
                {
                    if (m == 0) return n + 1;
                    else if (n == 0) return Ack(m - 1, 1);
                    else return Ack(m - 1, Ack(m, n - 1));
                }

                int InputNumbers(string input)
                {
                    Console.Write(input);
                    int output = Convert.ToInt32(Console.ReadLine());
                    return output;
                }
            }

            Task64(5, 30);
            //Task66();
            //Task68();
        }
    }
}
