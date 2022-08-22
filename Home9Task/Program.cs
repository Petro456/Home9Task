using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Програмка ніби працює, але вийшла трохи громіздкою. Я трохи не встигаю по завданнях,
            //   тому так її зробив, як буду встигати то порозкидую її по методах.
            //   Правда найшов вже готові методи і паралельно навів в прикладі.


            /*Задание 2

            Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
            Требуется: Создать массив размера N элементов, заполнить его произвольными целыми значениями 
            (размер массива задает пользователь). Вывести на экран: наибольшее значение массива, наименьшее значение массива,
            общую сумму всех элементов, среднее арифметическое всех элементов, вывести все нечетные значения. */

            Console.WriteLine("Введiть кiлькiсть елементiв масиву:");


            int N = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] masuv = new int[N];

            for (int i = 0; i < masuv.Length; i++)
            {
                masuv[i] = rand.Next(0, 10);
                Console.WriteLine("Значення масиву -  " + masuv[i]);
            }


            int min = 0;
            Console.WriteLine();
            Console.WriteLine("*************//////////////////////");

            for (int i = 0; i < masuv.Length; i++)
            {
                if (masuv[i] < masuv[min]) min = i;
            }
            Console.WriteLine("Мiнiмальнi значення  -  " + masuv[min]);
            Console.WriteLine("Мiнiмальнi значення  -  " + masuv.Min());
            int max = 0;
            Console.WriteLine("*************//////////////////////");

            for (int i = 0; i < masuv.Length; i++)
            {
                if (masuv[i] > masuv[max]) max = i;
            }
            Console.WriteLine("Максимальне значення  -  " + masuv[max]);
            Console.WriteLine("Максимальне значення в масиві : " + masuv.Max());
            double serSum = 0;
            int sum = 0;
            Console.WriteLine("*************//////////////////////");

            for (int i = 0; i < masuv.Length; i++)
            {
                sum += masuv[i];
            }
            serSum = sum / N;
            Console.WriteLine("Середнє арифметичне значення -  " + serSum);

            Console.WriteLine("Середнє арифметичне значення массива: " + masuv.Average());
            Console.WriteLine("*************//////////////////////");

            Console.WriteLine("Сума всiх значення -  " + sum);
            Console.WriteLine("*************//////////////////////");

            for (int i = 0; i < masuv.Length; i++)
            {
                if (masuv[i] % 2 == 0)
                    Console.WriteLine("Парнi значення -  " + masuv[i]);
            }

            Console.ReadKey();
        }


    }
    
}
