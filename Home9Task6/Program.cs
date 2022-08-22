using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9Task6
{
    internal class Program
    {
        static void ZvorotniiMasuv ( int[] massuv)
        {
            for (int i = massuv.Length - 1; i >= 0; --i)
            {
                Console.Write(massuv[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
           
            //for (int i = 0; i < massuv.Length; i++)
            //{                            
            //    Console.Write(massuv[i] + "\t");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //foreach (int i in massuv.Reverse())
            //{
            //    Console.Write(massuv[i] + "\t");
            //}

        }


        static void Main(string[] args)
        {
            /*Задание 6

                Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
            Создайте массив размерностью в 10 элементов, выведите на экран все элементы массива в обратном порядке.*/

            int[] massuv = new int[] {0,1,2,3,4,5,6,7,8,9};           

            ZvorotniiMasuv(massuv);
            
            Console.ReadKey();
        }
    }
}
