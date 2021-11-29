using System;
using MainLib;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Default;
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Введіть розмір масиву");
            int count = Convert.ToInt32(Console.ReadLine());
            int [] arr = new int [count];
            TaskArr.RandomArr(count);
            Console.Write("[\t");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = TaskArr.RandomArr(count)[i];
                Console.Write($"{arr[i]}\t");
            }
            Console.Write("]\n");
            TaskArr.SumNegative(arr); 
            Console.WriteLine($"Сума від’ємних елементів масиву = {TaskArr.SumNegative(arr)}");
            TaskArr.MaxNumberAmoungPairedElem(arr);
                Console.WriteLine($"Максимальний серед парних елементів масиву = {TaskArr.MaxNumberAmoungPairedElem(arr)}");
            TaskArr.MultiplicationOfPairedIndex(arr);
                Console.WriteLine($"Добуток елементів масиву, що мають парні індекси = {TaskArr.MultiplicationOfPairedIndex(arr)}");
            TaskArr.MaxIndex(arr);
                Console.WriteLine($"Номер (індекс) максимального елемента масиву= {TaskArr.MaxIndex(arr)}");
            TaskArr.AbsMaxNumber(arr);
                Console.WriteLine($"Максимальний за модулем елемент масиву= {TaskArr.AbsMaxNumber(arr)}");
            TaskArr.SumIndexWithPositiveElement(arr);
                Console.WriteLine($"Сума індексів додатних елементів = {TaskArr.SumIndexWithPositiveElement(arr)}");
            TaskArr.CountOfUnpairedElement(arr);
                Console.WriteLine($"Кількість непарних елементів масиву ={TaskArr.CountOfUnpairedElement(arr)}");
        }
    }
}
