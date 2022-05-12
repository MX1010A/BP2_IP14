using System;
using static Lab5.Func;

namespace Lab5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            Random rand = new Random();
            int n = 4;
            for (int i = 0; i < n; i++)
                lines2D[i] = new Line2D(new int[]{rand.Next(1, 6), rand.Next(1, 6)}, new int[]{rand.Next(1, 6), rand.Next(1, 6)});
            */
            Line2D[] lines2D = {
                new Line2D(new int[]{4, 5}, new int[]{3, 2}),
                new Line2D(new int[]{1, 6}, new int[]{5, 7}),
                new Line2D(new int[]{8, 5}, new int[]{5, 6}),
                new Line2D(new int[]{1, 8}, new int[]{2, 3}),
            };
            LinesOut(lines2D, "\nGenerated 2D lines:");
            int[] point2D = {2, 7};
            int index = 0;
            if(PointCheck(lines2D, point2D, ref index))
                Console.WriteLine( $"Point M{PointString(point2D)} belongs to line #{index + 1}: {lines2D[index].String()}, " +
                                   $"which is perpendicular to line #1: {lines2D[0].String()}");
            
            Line3D[] lines3D = {
                new Line3D(new int[]{4, 5, 2}, new int[]{3, 2, 3}),
                new Line3D(new int[]{8, 5, 2}, new int[]{5, 6, 2}),
                new Line3D(new int[]{4, 7, 2}, new int[]{3, 4, 3}),
                new Line3D(new int[]{4, 3, 2}, new int[]{3, 0, 3}),
            };
            LinesOut(lines3D, "\nGenerated 3D lines:");
            if(LineCheck(lines3D, ref index))
                Console.WriteLine($"Line #{index + 1}: {lines3D[index].String()} is perpendicular to all other lines");
        }
    }
}