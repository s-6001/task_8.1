using System;
using System.IO;

namespace task_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "d:/work"; //Задаем путь
            DirectoryInfo directory = new DirectoryInfo(path); //
            Console.WriteLine("Список каталогов в {0}:", path);
            foreach (var item1 in directory.GetDirectories()) //переберем все каталоги первого порядка
            {
                Console.WriteLine(item1.Name);
                //Console.WriteLine("    Список подкаталогов в {0}:", path);
                foreach (var item2 in item1.GetDirectories()) //переберем все каталоги второго порядка
                {
                    Console.WriteLine("    {0}", item2.Name);
                    foreach (var item3 in item2.GetDirectories()) //переберем все каталоги третьего порядка
                    {
                        Console.WriteLine("        {0}", item3.Name);
                    }
                    foreach (var file1 in item2.GetFiles()) //переберем файлы в каталогах второго порядка
                    {
                            Console.WriteLine("        {0}", file1.Name);
                    }
                    Console.WriteLine();
                }
                foreach (var file2 in item1.GetFiles()) //переберем файлы в каталогах первого порядка
                {
                    Console.WriteLine("    {0}", file2.Name);
                }
                Console.WriteLine();
            }
            foreach (var file3 in directory.GetFiles()) //переберем файлы в корневом каталоге
            {
                Console.WriteLine(file3.Name);
            }
            Console.ReadLine();
        }
    }
}