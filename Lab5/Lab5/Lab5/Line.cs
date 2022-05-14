using System.Linq;

namespace Lab5
{
    public abstract class Line
    {
        protected readonly int[] coordinatesA;
        protected readonly int[] coordinatesB;

        //конструктор з параметрами
        protected Line(int[] coordinatesA, int[] coordinatesB)
        {
            this.coordinatesA = coordinatesA;
            this.coordinatesB = coordinatesB;
        }
        
        //зведення прямої до вектора
        public int[] VectorCoordinates()
        {
            int[] vectorCoordinates = new int[coordinatesA.Length];
            for (int i = 0; i < coordinatesA.Length; i++)
                vectorCoordinates[i] = coordinatesB[i] - coordinatesA[i];
            return vectorCoordinates;
        }
        
        //представлення атрибутів об'єкта у вигляді рядка
        public override string ToString()
        {
            return $"A ({string.Join( "; ", coordinatesA.Select(x => x.ToString()).ToArray())}), " +
                   $"B ({string.Join( "; ", coordinatesB.Select(x => x.ToString()).ToArray())})";
        }
        
        //перевірка паралельності двох ліній
        public abstract bool IsParallel(Line line);
        
        //перевірка перпендикулярності двох ліній
        public abstract bool IsPerpendicular(Line line);
        
        //перевірка належності точки до прямої
        public abstract bool PointBelongs(int[] coordinatesP);
    }
}