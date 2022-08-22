using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9Task3
{
    internal class Program
    {

        //   Доброго вечоза. Я так і не зміг розібратись із логікою в другій частині завдання, буду вдячний якщо допоможите. 
      static void  MyReverse(int[] array)
        {


            for (int i = 0; i < array.Length; i++)
            {

                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            foreach (int i in array.Reverse())
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine("");

        }

       static int[] SubArray( int[] array, int index, int count)
        {
            for (int i = 0; i < array.Length; i++)
            {
             if (array[i] == index && count<array.Length)
                {
                    array[i] = index;
                }

                else if (array[i] == index&& count>array.Length)
                {
                    array[i] = count;
                }               
            }

            return array;
        }



        static void Main(string[] args)
        {
            /*Задание 3

            Используя Visual Studio, создайте проект по шаблону ConsoleApplication. Требуется:
            1) Создать метод MyReverse(int [ ] array), который принимает в качестве аргумента
            массив целочисленных элементов и возвращает инвертированный массив (элементы массива в обратном порядке). 
            2) Создайте метод int [ ] SubArray(int [ ] array, int index, int count). Метод возвращает часть полученного
            в качестве аргумента массива, начиная с позиции указанной в аргументе index, размерностью,
            которая соответствует значению аргумента count. Если аргумент count содержит значение больше чем количество элементов,
            которые входят в выбираемую часть исходного массива (от указанного индекса index, до индекса последнего элемента), 
            то при формировании нового массива размерностью в count, заполните единицами те элементы, которые не были скопированы
            из исходного массива. */


            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            MyReverse(array);
           
            Console.WriteLine("ВВедіть індехс масиву");
            int index=Convert.ToInt32(Console.ReadLine());
            int count =  index;
            SubArray(array, index, count);
            //int array2 = SubArray( array, index, count);
            
            Console.WriteLine(array);

            Console.ReadKey();
        }
    }
}
