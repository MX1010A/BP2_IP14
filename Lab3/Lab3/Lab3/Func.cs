using System;
using System.Collections.Generic;

namespace Lab3
{
    public static class Func
    {
        //знаходження круга з найбільшою площею
        public static int TheBiggest(List<Circle> list)
        {
            double maxArea = Double.MinValue;
            int maxCircle = 0;
            
            for (int i = 0; i < list.Count; i++)
                if (list[i].Area() > maxArea)
                {
                    maxArea = list[i].Area();
                    maxCircle = i;
                }
            return maxCircle;
        }
        
        //виведення списку кругів
        public static void ListOut(List<Circle> list, string comment) 
        {
            Console.WriteLine(comment);
            for (int i = 0; i < list.Count; i++) 
                Console.WriteLine($"{i + 1}. {list[i].String()}\t Area: {Math.Round(list[i].Area(), 2)} cm^2");
            Console.WriteLine();
        }
    }
}