namespace Lab5
{
    public class Line2D : Line
    {
        public Line2D(int[] coordinatesA, int[] coordinatesB) 
            : base(coordinatesA, coordinatesB) { }
        
        public override bool IsParallel(Line line)
        {
            return VectorCoordinates()[0] / line.VectorCoordinates()[0] == 
                   VectorCoordinates()[1] / line.VectorCoordinates()[1];
        }
        
        public override bool IsPerpendicular(Line line)
        {
            return VectorCoordinates()[0] * line.VectorCoordinates()[0] +
                   VectorCoordinates()[1] * line.VectorCoordinates()[1] == 0;
        }
 
        public override bool PointBelongs(int[] coordinatesP)
        {
            return IsParallel(new Line2D(coordinatesA, coordinatesP));
        }
    }
}