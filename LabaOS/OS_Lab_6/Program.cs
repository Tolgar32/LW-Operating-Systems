using System;
using System.Collections.Generic;

namespace OS_Practice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int max_size = 64 * 1024;
            
                    Console.Clear();
                    Console.WriteLine(" 1. Распределение памяти фиксированными разделами\n");
                    Console.WriteLine(" На сколько разделов вы хотите разделить оперативную память?");
                    Console.Write(" > ");
                    int c1 = OS_Inputing.OS_Int(1, OS_Inputing.Infinity);
                    List<int> sections1 = new();
                    for (int i1 = 0; i1 < c1; i1++)
                    {
                        Console.Write($"  Размер участка №{i1 + 1}> ");
                        int sect = OS_Inputing.OS_Int(1, max_size);
                        sections1.Add(sect);
                        max_size -= sect;
                    }
                    sections1.Add(max_size);
                    _ = new FixedSections(c1, sections1);
        }
    }
}
