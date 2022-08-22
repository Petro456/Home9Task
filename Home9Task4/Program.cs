using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9Task4
{
    internal class Program
    {
        //В першы частины також не перезберігає значення із доданим одним
        //Друга частина завдання не получається нормально викликати, щоб відобразити значення, виводить System.Int32[]
        // Можите глянути, буду вдячний!

        static void ZbilchennaMasuvy(int[] massiv)
        {

            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write(massiv[i] + "\t");                             
            }
            Console.WriteLine();
            Console.WriteLine();

            var zbmassuv = new int [massiv.Length + 1];
            for (int i = 0; i < massiv.Length; i++)
            {
                 zbmassuv[i] = massiv[i];                
                Console.Write(zbmassuv[i] + "\t");               
            }
            Console.WriteLine();
        }

        public static int[] Add(int[] array, int value)
        {

            Array.Resize<int>(ref array, array.Length + 1);

            for (int i = array.Length - 2; i >= 0; i--)
            array[i + 1] = array[i];
            array[0] = value;
            return array;

        }

        static void Main(string[] args)
        {
            //Задание 4

            /* Используя Visual Studio, создайте проект по шаблону ConsoleApplication.Требуется: 
             * Создать метод, который будет выполнять увеличение длины массива переданного в качестве аргумента,
                 на 1 элемент.Элементы массива, должны сохранить свое значение и порядок индексов. 
             * Создайте метод, который принимает два аргумента, первый аргумент -типа int[] array, 
              второй аргумент - типа int value. В теле метода реализуйте возможность добавления второго аргумента метода
            в массив по индексу – 0,при этом длина нового массива, должна увеличиться на 1 элемент,
            а элементы получаемого массива в качестве первого аргумента должны скопироваться в новый массив начиная с индекса -1.*/
           
            int[] massiv = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ZbilchennaMasuvy(massiv);
            Console.WriteLine("/////////////////////////////////////////////////");


            int value = 0;


            int[] resultat = Add(array, value);

           

            Console.Write(resultat);


            Console.ReadKey();
        }
    }
}
