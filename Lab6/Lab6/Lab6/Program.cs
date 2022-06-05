using System;
using static Lab6.Func;

namespace Lab6
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            string expression = "(a*(b+c))/d";
            Node root = GenerateTree(expression);
            Console.WriteLine($"\nBinary tree for {expression}:");
            Console.WriteLine($"Level #1: {root}\n{String(root, 2)}");
        }
    }
}