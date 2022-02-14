using System;
using System.IO;

namespace Lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TextInput();
            FileRead(1);
            FileRecreate();
            FileRead(2);
        }
        
        static void TextInput() //запис тексту у файл
        {
            StreamWriter sw = File.Exists("file1_cs.txt") ? File.AppendText("file1_cs.txt") : File.CreateText("file1_cs.txt");
            Console.WriteLine("\nEnter some text:\n");
            while (true)
            {
                var line = Console.ReadLine();
                if (line != "" && line[0] != 19) //19 = ctrl + S
                    sw.WriteLine(line);
                else if (line == "")
                    sw.WriteLine(line);
                else break;
            }
            sw.Close();
        }
        
        static void FileRecreate() //створення нового файлу з форматованим текстом першого файлу
        {
            StreamWriter sw = File.CreateText("file2_cs.txt");
            StreamReader sr = File.OpenText("file1_cs.txt");
            string str = "";
            string[] sent = TextFormat(File.ReadAllLines("file1_cs.txt"));
            for (int i = 0; i < sent.Length-1; i++)
            {
                int max = 0, ind = 0;
                string[] word = sent[i].Split(' ');
                for (int j = 0; j < word.Length; j++)
                {
                    int len = word[j].Trim(',').Length;
                    if (len > max)
                    {
                        max = len;
                        ind = j;
                    }
                }
                str += $"[{max} - {word[ind].Trim(',')}]{Tab(max)}{sent[i]}.\n";
            }
            sw.WriteLine(str);
            sw.Close();
            sr.Close();
        }

        static string[] TextFormat(string[] str) //поділ тексту на речення
        {
            string s = string.Join(" ", str);
            str = s.Split('.');
            for (int i = 0; i < str.Length; i++)
                str[i] = str[i].Trim();
            return str;
        }

        static string Tab(int max) //форматування табуляції
        {
            string tab = "";
            for (int k = 0; k < (max >= 17 ? 0 : Math.Abs(max/10 - 2)); k++)
                tab += "\t";
            return tab;
        }

        static void FileRead(int n) //виведення вмісту файлу
        {
            StreamReader sr = File.OpenText($"file{n}_cs.txt");
            Console.WriteLine($"\nText in file #{n}:\n\n{sr.ReadToEnd()}");
            sr.Close();
        }
    }
}