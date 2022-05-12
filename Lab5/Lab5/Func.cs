using System;

namespace Lab5
{
    public class Func
    {
        public static bool PointCheck(Line[] lines, int[] point, ref int index)
        {
            for (int i = 1; i < lines.Length; i++)
                if (lines[i].IsPerpendicular(lines[0]))
                    if (lines[i].BelongsToLine(point))
                    {
                        index = i;
                        return true;
                    }
            return false;
        }

        public static bool LineCheck(Line[] lines, ref int index)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                bool exists = false;
                foreach (var t in lines)
                {
                    if (lines[i] == t) continue;
                    exists = lines[i].IsPerpendicular(t);
                }
                if (exists)
                {
                    index = i;
                    return true;
                }
            }
            return false;
        }
        public static void LinesOut(Line[] lines, string comment)
        {
            Console.WriteLine(comment);
            for (int i = 0; i < lines.Length; i++)
                Console.WriteLine($"Line #{i + 1}:\t{lines[i].String()}");
            Console.WriteLine();
        }
        
        public static string PointString(int[] point)
        {
            string pointStr = $"({point[0]}";
            for (int i = 1; i < point.Length; i++)
                pointStr += $"; {point[i]}";
            return pointStr + ")";
        }
    }
}