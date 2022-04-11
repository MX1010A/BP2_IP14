using System;
using System.Collections.Generic;
using static Lab3.Func;

namespace Lab3
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var circlesList = new List<Circle>
            {
                new(20, -9, 8),
                new(12, 6, -3),
                new(9, 1, 2),
                new(24, 5, -4),
                new(17, -3, 1)
            };
            ListOut(circlesList, "\nList of circles with their area:");
            
            int maxCircle = TheBiggest(circlesList);
            double maxArea = Math.Round(circlesList[maxCircle].Area(), 2);
            Console.WriteLine($"Circle with the biggest area ({maxArea} cm^2) - circle #{maxCircle + 1}:");
            Console.WriteLine(circlesList[maxCircle].String());
        }
    }
}