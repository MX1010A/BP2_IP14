using System;
using System.Linq;

namespace Lab5
{
    public class Func
    {
        //перевірка прямих масиву на першу вказану властивість 
        public static bool PointCheck(Line[] lines, int[] point, ref int index)
        {
            for (int i = 1; i < lines.Length; i++)
                if (lines[i].IsPerpendicular(lines[0]))
                    if (lines[i].PointBelongs(point))
                    {
                        index = i;
                        return true;
                    }
            return false;
        }
        
        //перевірка прямих масиву на другу вказану властивість 
        public static bool LineCheck(Line[] lines, ref int index)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                bool exists = false;
                foreach (var line in lines)
                {
                    if (lines[i] == line) continue;
                    exists = lines[i].IsPerpendicular(line);
                }
                if (exists)
                {
                    index = i;
                    return true;
                }
            }
            return false;
        }
        
        //виведення масиву прямих
        public static void LinesOut(Line[] lines, string comment)
        {
            Console.WriteLine(comment);
            for (int i = 0; i < lines.Length; i++)
                Console.WriteLine($"Line #{i + 1}:\t{lines[i]}");
            Console.WriteLine();
        }
        
        //перетворення координат точки у рядок
        public static string PointString(int[] point)
        {
            return $"({string.Join("; ", point.Select(x => x.ToString()).ToArray())})";
        }
    }
}