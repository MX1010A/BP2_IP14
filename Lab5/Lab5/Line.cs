using System.Collections.Generic;

namespace Lab5
{
    public abstract class Line
    {
        protected readonly int[] coordinatesA;
        protected readonly int[] coordinatesB;

        protected Line(int[] coordinatesA, int[] coordinatesB)
        {
            this.coordinatesA = coordinatesA;
            this.coordinatesB = coordinatesB;
        }
        
        public List<int> VectorCoordinates()
        {
            List<int> vectorCoordinates = new List<int>();
            for (int i = 0; i < coordinatesA.Length; i++)
                vectorCoordinates.Add(coordinatesB[i] - coordinatesA[i]);
            return vectorCoordinates;
        }
        
        public string String()
        {
            string line = $"A({coordinatesA[0]}";
            for (int i = 1; i < coordinatesA.Length; i++)
                line += $"; {coordinatesA[i]}";
            
            line += $"), B({coordinatesB[0]}";
            for (int i = 1; i < coordinatesB.Length; i++)
                line += $"; {coordinatesB[i]}";
            
            return line + ")";
        }
        
        public abstract bool IsParallel(Line line);
        
        public abstract bool IsPerpendicular(Line line);
        
        public abstract bool BelongsToLine(int[] coordinatesP);
    }
}