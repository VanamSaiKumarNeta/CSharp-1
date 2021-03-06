﻿using System;
using System.IO;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read every line in the file:" + Environment.NewLine); 
            using (var reader = new StreamReader("D:\\File1.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);   
                }
            }

            Console.WriteLine(Environment.NewLine);
            Console.ReadLine();
            
            Console.WriteLine("Read all line in the file:" + Environment.NewLine);
            string file = File.ReadAllText(@"D:\File1.txt");
            Console.WriteLine(file);

            Console.WriteLine(Environment.NewLine);
            Console.ReadLine();

            Console.WriteLine("Read all line in the file:" + Environment.NewLine);

            string[] lines = File.ReadAllLines(@"D:\File1.txt");
            Console.WriteLine("Line Count: "+ lines.Length);
            foreach (string line in lines)
            {   
                if (line.Length > 100)
                {
                    Console.WriteLine("line length is greater than 100");
                }

                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}
